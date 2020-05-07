using System;
using System.Windows.Forms;

namespace QuizScoreTracker.Forms
{
    public partial class TeamNameDialog : Form
    {
        public string TeamName { get; private set; }

        public TeamNameDialog()
        {
            InitializeComponent();
        }

        private void OK_Click(object sender, EventArgs e)
        {
            TeamName = TeamNameTextbox.Text.Trim();

            DialogResult = DialogResult.OK;            
        }

        private void TeamNameTextbox_TextChanged(object sender, EventArgs e)
        {
            if (OK.Enabled && string.IsNullOrWhiteSpace(TeamNameTextbox.Text))
            {
                OK.Enabled = false;
            }
            else if (!OK.Enabled && !string.IsNullOrWhiteSpace(TeamNameTextbox.Text))
            {
                OK.Enabled = true;
            }            
        }
    }
}