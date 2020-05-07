using QuizScoreTracker.Managers;
using QuizScoreTracker.Models;
using QuizScoreTracker.Models.Configs;
using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace QuizScoreTracker.Forms
{
    public partial class SettingsDialog : Form
    {
        private bool _formLoaded = false;

        public Configuration Config { get; private set; }

        public SettingsDialog()
        {
            InitializeComponent();
        }

        public SettingsDialog(Configuration configuration)
            : this()
        {
            Config = Configuration.Clone(configuration);
        }

        private void OK_Click(object sender, EventArgs e)
        {
            ConfigurationManager.SaveConfiguration(Config);

            DialogResult = DialogResult.OK;
        }

        private async void CheckNow_Click(object sender, EventArgs e)
        {
            var check = UpdateManager.CheckForUpdateAsync(Config.Update.UpdateChannel);

            var updateDetails = await check;

            if (updateDetails.UpdateAvailable)
            {
                using (var update = new UpdateDialog(updateDetails.UpdateNotes))
                {
                    update.ShowDialog();
                }
            }

            Config.Update.LastCheckDate = DateTime.Today;

            ConfigurationManager.UpdateLastUpdateDate();

            LastCheck.Text = $"Last checked: {Config.Update.LastCheckDate:yyyy-MM-dd}";
        }

        private void SettingsDialog_Load(object sender, EventArgs e)
        {
            ShowNumericalScore.Checked = Config.General.ShowNumericalScore;
            ScorePerQuestion.SelectedIndex = ScorePerQuestion.Items.IndexOfFirst(i => i.Contains($"{Config.General.ScorePerQuestion}"));

            UpdateChannel.DataSource = Enum.GetNames(typeof(ChannelType));
            CheckOnStartup.Checked = Config.Update.CheckForUpdates;
            CheckFrequency.SelectedIndex = CheckFrequency.Items.IndexOfFirst(i => Config.Update.CheckFrequency != 1 && i.Contains($"{Config.Update.CheckFrequency}"));
            UpdateChannel.SelectedItem = $"{Config.Update.UpdateChannel}";
            LastCheck.Text = $"Last checked: {Config.Update.LastCheckDate:yyyy-MM-dd}";

            _formLoaded = true;
        }

        private void CheckOnStartup_CheckedChanged(object sender, EventArgs e)
        {
            if (!_formLoaded) { return; }

            Config.Update.CheckForUpdates = CheckOnStartup.Checked;
        }

        private void CheckFrequency_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!_formLoaded) { return; }

            var option = $"{CheckFrequency.SelectedItem}";

            var regex = Regex.Match(option, @"(?<Days>\d+)");

            Config.Update.CheckFrequency = regex.Success ? int.Parse(regex.Groups["Days"].Value) : 1;
        }

        private void UpdateChannel_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!_formLoaded) { return; }

            Config.Update.UpdateChannel = (ChannelType)Enum.Parse(typeof(ChannelType), $"{UpdateChannel.SelectedItem}");
        }

        private void ShowNumericalScore_CheckedChanged(object sender, EventArgs e)
        {
            if (!_formLoaded) { return; }

            Config.General.ShowNumericalScore = ShowNumericalScore.Checked;
        }

        private void ScorePerQuestion_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!_formLoaded) { return; }

            var option = $"{ScorePerQuestion.SelectedItem}";

            var regex = Regex.Match(option, @"(?<ScorePerQuestion>\d+)");

            Config.General.ScorePerQuestion = regex.Success ? int.Parse(regex.Groups["ScorePerQuestion"].Value) : 1;
        }
    }
}