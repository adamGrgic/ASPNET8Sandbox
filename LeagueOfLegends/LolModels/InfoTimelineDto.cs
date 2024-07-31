using System.ComponentModel.DataAnnotations;

namespace SandboxModule.LeagueOfLegends.LolModels
{
    public class InfoTimelineDto
    {
        public required string EndOfGameResult { get; set; }
        public long FrameInterval { get; set; }
        public long GameId { get; set; }
        public required List<ParticipantTimelineDto> Participants { get; set; }
        public required List<FramesTimelineDto> Frames { get; set; }
    }
}
