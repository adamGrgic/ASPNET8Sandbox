namespace SandboxModule.Modules.LeagueOfLegends.LolModels
{
    public class FramesTimelineDto
    {
        public List<EventsTimeLineDto> Events { get; set; }
        public dynamic? ParticipantFrames { get; set; }
        public int Timestamp { get; set; }
    }
}
