using Newtonsoft.Json;
using System.Text.Json.Serialization;

namespace SandboxModule.Archive.LeagueOfLegends.LolModels
{
    public class ParticipantFramesDto
    {
        [JsonPropertyName("1")]
        public ParticipantFrameDto? ParticipantOne { get; set; }

        [JsonPropertyName("2")]
        public ParticipantFrameDto? ParticipantTwo { get; set; }

        [JsonPropertyName("3")]
        public ParticipantFrameDto? ParticipantThree { get; set; }


        [JsonPropertyName("4")]
        public ParticipantFrameDto? ParticipantFour { get; set; }

        [JsonPropertyName("5")]
        public ParticipantFrameDto? ParticipantFive { get; set; }

        [JsonPropertyName("6")]
        public ParticipantFrameDto? ParticipantSix { get; set; }

        [JsonPropertyName("7")]
        public ParticipantFrameDto? ParticipantSeven { get; set; }

        [JsonPropertyName("8")]
        public ParticipantFrameDto? ParticipantEight { get; set; }

        [JsonPropertyName("9")]
        public ParticipantFrameDto? ParticipantNine { get; set; }

        [JsonPropertyName("10")]
        public ParticipantFrameDto? ParticipantTen { get; set; }
    }
}
