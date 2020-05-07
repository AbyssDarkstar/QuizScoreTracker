using QuizScoreTracker.Managers;
using System;
using System.Windows.Forms;

namespace QuizScoreTracker.Forms
{
    public partial class UpdateDialog : Form
    {
        public UpdateDialog()
        {
            InitializeComponent();
        }

        public UpdateDialog(string changeLog)
            : this()
        {
            ChangeLogTextbox.Text = changeLog;
        }

        private async void UpdateButton_Click(object sender, EventArgs e)
        {
            DownloadProgress.Visible = true;
            UpdateManager.ProgressChanged += UpdateManager_ProgressChanged;

            await UpdateManager.DownloadUpdateAsync();

            UpdateManager.ProgressChanged -= UpdateManager_ProgressChanged;
            DownloadProgress.Visible = false;

            UpdateManager.RunInstaller();
            Application.Exit();
        }

        private void UpdateManager_ProgressChanged(long? totalFileSize, long totalBytesDownloaded, double? progressPercentage)
        {
            if (progressPercentage != null)
            {
                DownloadProgress.Value = (int)Math.Floor(progressPercentage.Value);
            }
        }
    }
}