using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using QuizScoreTracker.Converters;
using System;

namespace QuizScoreTracker.Models.Configs
{
    [JsonObject(MemberSerialization.OptIn)]
    public class UpdateConfiguration
    {
        [JsonProperty("checkForUpdates")]
        public bool CheckForUpdates { get; set; }

        [JsonProperty("updateChannel"), JsonConverter(typeof(StringEnumConverter))]
        public ChannelType UpdateChannel { get; set; }

        [JsonProperty("checkFrequency")]
        public int CheckFrequency { get; set; }

        [JsonProperty("lastCheckDate"), JsonConverter(typeof(DateConverter))]
        public DateTime LastCheckDate { get; set; }

        public static UpdateConfiguration Default
        {
            get
            {
                return new UpdateConfiguration
                {                    
                    CheckForUpdates = true,
                    UpdateChannel = ChannelType.Release,
                    CheckFrequency = 14,
                    LastCheckDate = new DateTime(1970, 1, 1)                    
                };
            }
        }

        public static UpdateConfiguration Clone(UpdateConfiguration configuration)
        {
            return new UpdateConfiguration
            {
                CheckForUpdates = configuration.CheckForUpdates,
                UpdateChannel = configuration.UpdateChannel,
                CheckFrequency = configuration.CheckFrequency,
                LastCheckDate = configuration.LastCheckDate                
            };
        }
    }
}