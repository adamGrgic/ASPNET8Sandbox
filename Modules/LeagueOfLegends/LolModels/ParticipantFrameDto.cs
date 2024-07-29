namespace SandboxModule.Modules.LeagueOfLegends.LolModels
{
    public class ParticipantFrameDto
    {
        public ChampionStatsDto ChampionStats { get; set; }
        public int CurrentGold { get; set; }
        public DamageStatsDto DamageStats { get; set; }
        public int GoldPerSecond { get; set; }
        public int JungleMinionsKill { get; set; }
        public int Level { get; set; }
        public int MinionsKilled { get; set; }
        public int ParticipantId { get; set; }
        public PositionDto Position { get; set; }
        public int TimeEnemySpentControlled { get; set; }
        public int TotalGold { get; set; }
        public int Xp { get; set; }


    }
}
