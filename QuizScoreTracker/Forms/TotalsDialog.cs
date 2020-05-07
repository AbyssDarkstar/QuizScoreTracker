using QuizScoreTracker.Controls;
using QuizScoreTracker.Models;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace QuizScoreTracker.Forms
{
    public partial class TotalsDialog : Form
    {
        public TotalsDialog()
        {
            InitializeComponent();
        }

        public TotalsDialog(Dictionary<string, Score> scores)
            : this()
        {
            int i = 1;
            foreach (var team in scores.OrderByDescending(s => s.Value.OverallScore).ThenBy(s => s.Key))
            {
                var score = new TeamScores(i++, team.Key, team.Value);
                ScoresFlowLayout.Controls.Add(score);
            }
        }
    }
}