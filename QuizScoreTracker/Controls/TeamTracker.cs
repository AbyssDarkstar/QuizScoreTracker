using QuizScoreTracker.Models;
using QuizScoreTracker.Properties;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace QuizScoreTracker.Controls
{
    public partial class TeamTracker : UserControl
    {
        private bool _showScoreInDigits;
        private int _scorePerQuestion;

        public string TeamName { get; private set; }
        public Score CurrentScore { get; private set; }

        public bool ShowScoreInDigits
        {
            get => _showScoreInDigits;
            set
            {
                _showScoreInDigits = value;
                PositiveTally.Width = _showScoreInDigits ? 158 : 194;
                NegativeTally.Width = _showScoreInDigits ? 158 : 194;
            }
        }

        public int ScorePerQuestion
        {
            get => _scorePerQuestion;
            set
            {
                _scorePerQuestion = value;
                AddScore.Text = $"+{_scorePerQuestion}";
                RemoveScore.Text = $"-{_scorePerQuestion}";
            }
        }

        public TeamTracker()
        {
            InitializeComponent();
        }

        public TeamTracker(string teamName, bool showScoreInDigits, int scorePerQuestion)
            : this()
        {
            TeamName = teamName;
            TeamNameLabel.Text = TeamName;
            FullNameTooltip.SetToolTip(TeamNameLabel, TeamName);

            ShowScoreInDigits = showScoreInDigits;
            ScorePerQuestion = scorePerQuestion;

            CurrentScore = new Score();
        }

        private void AddScore_Click(object sender, EventArgs e)
        {
            CurrentScore.PositiveScore += ScorePerQuestion;

            PositiveScore.Text = $"{CurrentScore.PositiveScore}";

            if (PositiveTally.HasChildren)
            {
                var lastChild = (PictureBox)PositiveTally.Controls[PositiveTally.Controls.Count - 1];

                if((int)lastChild.Tag + ScorePerQuestion > 5)
                {
                    var remainder = (int)lastChild.Tag + ScorePerQuestion - 5;

                    lastChild.UpdateImage(5);                    

                    var p = new PictureBox { Size = new Size(22, 18) };
                    p.UpdateImage(remainder);
                    PositiveTally.Controls.Add(p);
                }
                else
                {
                    lastChild.UpdateImage((int)lastChild.Tag + ScorePerQuestion);
                }
            }
            else
            {
                var p = new PictureBox { Size = new Size(22, 18) };
                p.UpdateImage(ScorePerQuestion);
                PositiveTally.Controls.Add(p);
            }
        }

        private void RemoveScore_Click(object sender, EventArgs e)
        {
            CurrentScore.NegativeScore += ScorePerQuestion;

            NegativeScore.Text = $"{CurrentScore.NegativeScore}";

            if (NegativeTally.HasChildren)
            {
                var lastChild = (PictureBox)NegativeTally.Controls[NegativeTally.Controls.Count - 1];

                if ((int)lastChild.Tag + ScorePerQuestion > 5)
                {
                    var remainder = (int)lastChild.Tag + ScorePerQuestion - 5;

                    lastChild.UpdateImage(5);

                    var p = new PictureBox { Size = new Size(22, 18) };
                    p.UpdateImage(remainder);
                    NegativeTally.Controls.Add(p);
                }
                else
                {
                    lastChild.UpdateImage((int)lastChild.Tag + ScorePerQuestion);
                }
            }
            else
            {
                var p = new PictureBox { Size = new Size(22, 18) };
                p.UpdateImage(ScorePerQuestion);
                NegativeTally.Controls.Add(p);
            }
        }

        
    }
}