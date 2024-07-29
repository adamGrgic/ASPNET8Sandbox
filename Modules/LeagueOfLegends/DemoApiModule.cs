using Microsoft.AspNetCore.Mvc;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using SandboxModule.Modules.LeagueOfLegends.LolModels;
using Newtonsoft.Json.Linq;


namespace SandboxModule.Modules.LeagueOfLegends
{

    [Route("[controller]/[action]")]
    public class DemoApiModule : ControllerBase
    {

        private readonly HttpClient _httpClient;

        public DemoApiModule(HttpClient httpClient)
        {

            _httpClient = httpClient;

        }

        [HttpGet]
        public async Task<IActionResult> GetMatchInfo()
        {
            var apiKey = "";

            var matchId = "";

            var url = $"https://americas.api.riotgames.com/lol/match/v5/matches/{matchId}/timeline?api_key={apiKey}";

            var response = await _httpClient.GetAsync(url);
            response.EnsureSuccessStatusCode();

            string content = await response.Content.ReadAsStringAsync();


            // first we need to deserialize MetaDataTimelineDTO
            
            var metaData = JsonConvert.DeserializeObject<TimelineDto>(content);

            //  given puuid find participant (metaData.MetaData.Participants)

            //  (for now hardcode at FDqatUgp3-7CXBHnmWQFa0E8ozyDxSFV6q2KTyGGS0SejREh5sfQSHDR2qraHwFYjfTw5-4QCDtVZQ)
            //  (position [2) currently)
            //  

            //
            var metrics = new List<PerformanceMetric>();
            //var foo = metaData?.Info?.Frames[1].ParticipantFrames as JObject;
            foreach (var frame in metaData?.Info?.Frames)
            {
                var stats = frame?.ParticipantFrames?["3"].ToObject<ParticipantFrameDto>();
            }
            //var thing = foo.Property("3").ToString();
            //var dude = foo["3"].ToObject<ParticipantFrameDto>();
            //var bar = JsonConvert.DeserializeObject<ParticipantFramesDto>(foo.ToString());
            

            return Ok(content);
        }

    }
}
