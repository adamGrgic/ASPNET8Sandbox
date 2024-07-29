namespace SandboxModule.Modules.LeagueOfLegends.LolModels
{
    public class InfoTimelineDto
    {
        public string EndOfGameResult { get; set; }
        //public long FrameInterval { get; set; }
        //public long GameId { get; set; }
        public List<ParticipantTimelineDto> Participants { get; set; }
        public required List<FramesTimelineDto> Frames { get; set; }
    }
}
