using Microsoft.AspNetCore.Mvc;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Text;
using SandboxModule.LeagueOfLegends.LolModels;
using System.Web;
using Microsoft.AspNetCore.Hosting;

namespace SandboxModule.LeagueOfLegends
{

    [Route("[controller]/[action]")]
    public class DemoApiModule : ControllerBase
    {

        private readonly HttpClient _httpClient;
        private readonly IWebHostEnvironment _webHostEnvironment;
        public DemoApiModule(HttpClient httpClient, IWebHostEnvironment webHostEnvironment)
        {

            _webHostEnvironment = webHostEnvironment;
            _httpClient = httpClient;

        }

        [HttpGet]
        public async Task<IActionResult> GetMatchInfo()
        {
            // prototyping an api/service for processing match data 

            // TODO: find a better place to put this
            var apiKey = "";

            // for now -- add as param later
            // -> for now we use puuid, should be able to use either gameName + tag || puuid
            var puuid = "";

            // TODO: get list of matches
            var matchId = "";

            // (?) TODO: add to config
            var url = $"https://americas.api.riotgames.com/lol/match/v5/matches/{matchId}/timeline?api_key={apiKey}";

            var response = await _httpClient.GetAsync(url);
            response.EnsureSuccessStatusCode();

            var content = await response.Content.ReadAsStringAsync();

            if (content == null)
            {
                throw new InvalidOperationException("Error while attempting to parse request.");
            }

            var timeLineData = JsonConvert.DeserializeObject<TimelineDto>(content);

            var participant = timeLineData?.Info?.Participants?.FirstOrDefault(x => x.Puuid == puuid)?.participantId;

            if (participant == null)
            {
                throw new InvalidOperationException("Participant could not be found");
            }

            var metrics = new List<PerformanceMetric>();

            var frames = timeLineData?.Info?.Frames;
            if (frames != null)
            {
                foreach (var frame in frames)
                {
                    var stats = frame?.ParticipantFrames?[participant]?.ToObject<ParticipantFrameDto>();

                    if (stats != null)
                    {
                        metrics.Add(new PerformanceMetric
                        {
                            Cs = stats.MinionsKilled,
                            Level = stats.Level,
                            AbilityPower = stats.ChampionStats.AbilityPower,
                        });
                    }

                    // TODO: Add logic to process event data
                    // look into events array 
                    // find where participant id is equal
                    // look for CHAMPION_KILL events
                    // look at assists + killerId for K/A
                    // look at victimId for D

                }
            }


            // create csv for export
            // TODO: consider other export options

            var csv = new StringBuilder();
            var directory = $"{_webHostEnvironment.ContentRootPath}/LeagueOfLegends/CsvOutput";
            CsvHelper.WriteListToCsv(metrics, $"{directory}/analytics{DateTime.Now:yyyyMMddHHmmssffff}");
            return Ok(metrics);
        }

    }
}
