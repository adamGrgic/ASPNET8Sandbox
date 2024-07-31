using Microsoft.AspNetCore.Mvc;
using SandboxModule.LeagueOfLegends.LolModels;
using System.Text;

namespace SandboxModule.LeagueOfLegends
{
    public static class CsvHelper
    {
        public static void WriteListToCsv(List<PerformanceMetric> metrics, string fileName)
        {
            var csv = new StringBuilder();

            // Add the header
            csv.AppendLine("Time,AbilityPower");

            // Add the data rows
            for (var i = 1; i < metrics.Count; i++)
            {

                csv.AppendLine($"{i}, {metrics[i].AbilityPower}");
            }

            // Write to file
            File.WriteAllText(fileName, csv.ToString());
        }
    }
}
