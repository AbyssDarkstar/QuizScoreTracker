using Newtonsoft.Json;
using QuizScoreTracker.Models.Configs;
using System;
using System.IO;

namespace QuizScoreTracker.Managers
{
    public class ConfigurationManager
    {
        private static readonly string _configFile = "Configuration";

        public static string ConfigPath
        {
            get => Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "Studio Darkstar", "Quiz Score Tracker");
        }

        static ConfigurationManager()
        {
            if (!Directory.Exists(ConfigPath))
            {
                Directory.CreateDirectory(ConfigPath);
            }

            if (!File.Exists(Path.Combine(ConfigPath, _configFile)))
            {
                var config = Configuration.Default;

                SaveConfiguration(config);
            }
        }

        public static Configuration LoadConfiguration()
        {
            try
            {
                return JsonConvert.DeserializeObject<Configuration>(File.ReadAllText(Path.Combine(ConfigPath, _configFile)));
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static void SaveConfiguration(Configuration configuration)
        {
            try
            {
                File.WriteAllText(Path.Combine(ConfigPath, _configFile), JsonConvert.SerializeObject(configuration, Formatting.Indented));
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static void UpdateLastUpdateDate()
        {
            var config = LoadConfiguration();

            config.Update.LastCheckDate = DateTime.Today;

            SaveConfiguration(config);
        }
    }
}