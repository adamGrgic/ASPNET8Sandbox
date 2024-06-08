﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using SandboxModule;
using SandboxModule.Modules.LINQDictionary.Models;
using System.Diagnostics;
using System.Text;

namespace SandboxModule.Modules.LINQDictionary
{
    // Inherit from BaseModuleController and add "LINQDictionary" prefix
    [Route("[controller]/[action]")]
    public class LINQDictionaryBaseModule : Controller
    {
        public LINQDictionaryBaseModule()
        {

        }

        
        public Stopwatch Selectv1([FromBody] LINQParameterConfigurationModel configuration)
        {

            var randomStringList = new List<string>();

            for (var i = 0; i < configuration.RandomStringListCount; i++)
            {
                randomStringList.Add(GenerateRandomString(configuration.RandomStringLength, configuration.RandomStringListVariance));
            }

            var random = new Random();
            var upperThreshold = randomStringList.Count;

            for (var i = 0; i < configuration.RandomStringListBuilderIterations; i++)
            {
                var randomInteger = random.Next(randomStringList.Count);
                var randomString = randomStringList[randomInteger];
                randomStringList.Add(randomString);
            }

            var randomStringTransformation = GenerateRandomString(configuration.RandomStringTransformationLength);

            Stopwatch stopwatch = Stopwatch.StartNew();
            
            var dog = randomStringList.Select(x => x + randomStringTransformation);

            stopwatch.Stop();

            return stopwatch;
        }


        public Stopwatch SelectToListv1([FromBody] LINQParameterConfigurationModel configuration)
        {

            var randomStringList = new List<string>();

            for (var i = 0; i < configuration.RandomStringListCount; i++)
            {
                randomStringList.Add(GenerateRandomString(configuration.RandomStringLength, configuration.RandomStringListVariance));
            }

            var random = new Random();
            var upperThreshold = randomStringList.Count;

            for (var i = 0; i < configuration.RandomStringListBuilderIterations; i++)
            {
                var randomInteger = random.Next(randomStringList.Count);
                var randomString = randomStringList[randomInteger];
                randomStringList.Add(randomString);
            }

            var randomStringTransformation = GenerateRandomString(configuration.RandomStringTransformationLength);

            var stopwatch = Stopwatch.StartNew();

            var dog = randomStringList.Select(x => x + randomStringTransformation).ToList();

            stopwatch.Stop();

            return stopwatch;
        }

        public Stopwatch Takev1([FromBody] LINQParameterConfigurationModel configuration)
        {
            var randomStringList = GenerateRandomStringList(
                    configuration.RandomStringListCount,
                    configuration.RandomStringLength,
                    configuration.RandomStringListVariance
                );

            if (configuration.RandomNumberVarianceSelection > 0)
            {
                var random = new Random();
                configuration.RandomNumberSelection = random.Next(configuration.RandomNumberVarianceSelection);
            }

            var stopwatch = Stopwatch.StartNew();

            var dog = randomStringList.Take(configuration.RandomNumberSelection);

            stopwatch.Stop();

            return stopwatch;

        }

        private List<string> GenerateRandomStringList(int numberOfStrings, int stringLength, int stringVariance)
        {
            var randomStringList = new List<string>();

            for (var i = 0; i < numberOfStrings; i++)
            {
                randomStringList.Add(GenerateRandomString(stringLength, stringVariance));
            }

            return randomStringList;
        }


        private string GenerateRandomString(int randomLetters, int variance = 0)
        {
            // for now
            // TODO: Add error handling for when variance is greater than random letters
            if (variance > 0)
            {
                var random = new Random();
                randomLetters = randomLetters - random.Next(variance);
            } 

            var randomString = new StringBuilder();


            for (int i = 0; i < randomLetters; i++)
            {
                var random = new Random();
                char randomLetter = (char)('a' + random.Next(0, 26));
                randomString.Append(randomLetter);
            }

            return randomString.ToString();

        }
    }
}