using QuizScoreTracker.Models;
using System.Windows.Forms;

namespace QuizScoreTracker.Controls
{
    public partial class TeamScores : UserControl
    {
        public TeamScores()
        {
            InitializeComponent();
        }

        public TeamScores(int position, string teamName, Score scores)
            :this()
        {
            Position.Text = $"#{position}";
            TeamName.Text = teamName;
            Maths.Text = $"{scores.PositiveScore} - {scores.NegativeScore} = {scores.OverallScore}";
        }
    }
}