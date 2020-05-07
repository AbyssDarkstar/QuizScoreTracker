using Newtonsoft.Json;

namespace QuizScoreTracker.Models.Configs
{
    [JsonObject(MemberSerialization.OptIn)]
    public class Configuration
    {
        [JsonProperty("general")]
        public GeneralConfiguration General { get; set; }

        [JsonProperty("update")]
        public UpdateConfiguration Update { get; set; }

        public static Configuration Default
        {
            get
            {
                return new Configuration
                {
                    General = GeneralConfiguration.Default,
                    Update = UpdateConfiguration.Default
                };
            }
        }

        public static Configuration Clone(Configuration configuration)
        {
            return new Configuration
            {
                General = GeneralConfiguration.Clone(configuration.General),
                Update = UpdateConfiguration.Clone(configuration.Update)
            };
        }
    }
}