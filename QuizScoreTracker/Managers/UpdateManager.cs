using Newtonsoft.Json;
using QuizScoreTracker.Http;
using QuizScoreTracker.Models;
using System;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace QuizScoreTracker.Managers
{
    public class UpdateManager
    {
        private static string UpdateCheckUri { get; } = "https://github.com/AbyssDarkstar/QuizScoreTracker/raw/versioning/QuizScoreTracker.json";

        private static string UpdateNotesPath { get; set; }
        public static string UpdateExePath { get; private set; }

        private static string UpdateTempPath { get; set; } = Path.Combine(ConfigurationManager.ConfigPath, "UpdateTemp");
        private static string UpdateTempExe { get; set; } = Path.Combine(UpdateTempPath, "Installer.exe");

        public delegate void ProgressChangedHandler(long? totalFileSize, long totalBytesDownloaded, double? progressPercentage);
        public static event ProgressChangedHandler ProgressChanged;

        public static async Task<UpdateDetails> CheckForUpdateAsync(ChannelType updateChannel)
        {
            var updateDetails = new UpdateDetails();

            try
            {
                using (var httpClient = new HttpClient())
                {
                    var json = await httpClient.GetStringAsync(UpdateCheckUri);

                    var liveVersion = JsonConvert.DeserializeObject<LiveVersioning>(json);
                    var channel = liveVersion.Channels.First(c => c.ChannelType == updateChannel);

                    UpdateNotesPath = channel.ChangeNotes;
                    UpdateExePath = channel.Download;

                    updateDetails.UpdateAvailable = AssemblyManager.Version < channel.Version;

                    if (updateDetails.UpdateAvailable)
                    {
                        updateDetails.UpdateNotes = await GetUpdateNotes();
                    }
                }

                return updateDetails;
            }
            catch (Exception)
            {
                throw;
            }
        }

        private static async Task<string> GetUpdateNotes()
        {
            if (string.IsNullOrWhiteSpace(UpdateNotesPath))
            {
                return "Unable to aquire change log.";
            }

            try
            {
                using (var httpClient = new HttpClient())
                {
                    var notes = await httpClient.GetStringAsync(UpdateNotesPath);

                    return notes;
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        private static void CheckAndClearTempDir()
        {
            if (!Directory.Exists(UpdateTempPath))
            {
                Directory.CreateDirectory(UpdateTempPath);
            }
            else
            {
                foreach (string file in Directory.GetFiles(UpdateTempPath))
                {
                    File.Delete(file);
                }
            }
        }

        public static async Task DownloadUpdateAsync()
        {
            CheckAndClearTempDir();

            var downloadFileUrl = UpdateExePath;
            var destinationFilePath = UpdateTempExe;

            using (var client = new HttpClientDownloadWithProgress(downloadFileUrl, destinationFilePath))
            {
                client.ProgressChanged += (totalFileSize, totalBytesDownloaded, progressPercentage) => {
                    ProgressChanged?.Invoke(totalFileSize, totalBytesDownloaded, progressPercentage);
                };

                await client.StartDownload();
            }
        }

        public static bool RunInstaller()
        {
            if (File.Exists(UpdateTempExe))
            {
                Process.Start(UpdateTempExe);
                return true;
            }

            return false;
        }
    }
}