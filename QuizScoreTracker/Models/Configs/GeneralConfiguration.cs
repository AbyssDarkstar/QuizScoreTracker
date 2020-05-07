using Newtonsoft.Json;

namespace QuizScoreTracker.Models.Configs
{
    [JsonObject(MemberSerialization.OptIn)]
    public class GeneralConfiguration
    {
        [JsonProperty("showNumericalScore")]
        public bool ShowNumericalScore { get; set; }

        [JsonProperty("scorePerQuestion")]
        public int ScorePerQuestion { get; set; }

        public static GeneralConfiguration Default
        {
            get
            {
                return new GeneralConfiguration
                {
                    ShowNumericalScore = false,
                    ScorePerQuestion = 1
                };
            }
        }

        public static GeneralConfiguration Clone(GeneralConfiguration configuration)
        {
            return new GeneralConfiguration
            {
                ShowNumericalScore = configuration.ShowNumericalScore,
                ScorePerQuestion = configuration.ScorePerQuestion
            };
        }
    }
}