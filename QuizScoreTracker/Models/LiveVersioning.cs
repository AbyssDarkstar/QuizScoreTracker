using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using QuizScoreTracker.Converters;
using System;
using System.Collections.Generic;

namespace QuizScoreTracker.Models
{
    public enum ChannelType
    {
        Beta = 0,
        Release = 1
    }

    [JsonObject(MemberSerialization.OptIn)]
    public class LiveVersioning
    {
        [JsonProperty("channels")]
        public List<Channel> Channels { get; set; }
    }

    [JsonObject(MemberSerialization.OptIn)]
    public class Channel
    {
        [JsonProperty("channel"), JsonConverter(typeof(StringEnumConverter))]
        public ChannelType ChannelType { get; set; }

        [JsonProperty("version"), JsonConverter(typeof(VersionConverter))]
        public Version Version { get; set; }

        [JsonProperty("date"), JsonConverter(typeof(DateConverter))]
        public DateTime Date { get; set; }

        [JsonProperty("download")]
        public string Download { get; set; }

        [JsonProperty("changeNotes")]
        public string ChangeNotes { get; set; }
    }
}