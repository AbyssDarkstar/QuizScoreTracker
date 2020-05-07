using QuizScoreTracker.Controls;
using QuizScoreTracker.Managers;
using QuizScoreTracker.Models;
using QuizScoreTracker.Models.Configs;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace QuizScoreTracker.Forms
{
    public partial class MainForm : Form
    {
        private Configuration _config;

        public MainForm()
        {
            InitializeComponent();
        }

        private void FileMenuNew_Click(object sender, EventArgs e)
        {
            TeamsFlowPanel.Controls.Clear();
        }

        private void FileMenuExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void AboutMenuItem_Click(object sender, EventArgs e)
        {
            using (var about = new AboutDialog())
            {
                about.ShowDialog();
            }
        }

        private void AddTeam_Click(object sender, EventArgs e)
        {
            using (var teamName = new TeamNameDialog())
            {
                if (teamName.ShowDialog() == DialogResult.OK)
                {
                    TeamsFlowPanel.Controls.Add(new TeamTracker(teamName.TeamName, _config.General.ShowNumericalScore, _config.General.ScorePerQuestion));
                }
            }
        }

        private void TeamsFlowPanel_ControlsChanged(object sender, ControlEventArgs e)
        {
            Teams.Text = $"{TeamsFlowPanel.Controls.Count}";
        }

        private void Totals_Click(object sender, EventArgs e)
        {
            var scores = new Dictionary<string, Score>();

            foreach (var ctrl in TeamsFlowPanel.Controls)
            {
                if (ctrl is TeamTracker tt)
                {
                    scores.Add(tt.TeamName, tt.CurrentScore);
                }
            }

            var totals = new TotalsDialog(scores);
            totals.ShowDialog();
        }

        private void EditMenuSettings_Click(object sender, EventArgs e)
        {
            using (var settings = new SettingsDialog(_config))
            {
                settings.ShowDialog();
                
                _config = ConfigurationManager.LoadConfiguration();

                UpdateVisuals();                                
            }
        }

        private void UpdateVisuals()
        {
            foreach(var ctrl in TeamsFlowPanel.Controls)
            {
                if(ctrl is TeamTracker tt)
                {
                    tt.ShowScoreInDigits = _config.General.ShowNumericalScore;
                    tt.ScorePerQuestion = _config.General.ScorePerQuestion;
                }
            }
        }

        private async void MainForm_Load(object sender, EventArgs e)
        {
            _config = ConfigurationManager.LoadConfiguration();

            if(_config.Update.LastCheckDate.AddDays(_config.Update.CheckFrequency) <= DateTime.Today)
            {
                var check = UpdateManager.CheckForUpdateAsync(_config.Update.UpdateChannel);

                var updateDetails = await check;

                if (updateDetails.UpdateAvailable)
                {
                    using (var update = new UpdateDialog(updateDetails.UpdateNotes))
                    {
                        update.ShowDialog();
                    }
                }

                _config.Update.LastCheckDate = DateTime.Today;
                ConfigurationManager.UpdateLastUpdateDate();
            }
        }
    }
}