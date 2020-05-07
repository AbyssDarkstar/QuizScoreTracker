namespace QuizScoreTracker.Models
{
    public class Score
    {
        public int PositiveScore { get; set; }

        public int NegativeScore { get; set; }

        public int OverallScore { get { return PositiveScore - NegativeScore; } }
    }
}