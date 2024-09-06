using System.Text;

namespace Sandbox.Api.SandboxUtils
{
    public static class Strings
    {
        public static List<string> GenerateRandomStringList(int numberOfStrings, int stringLength, int stringVariance)
        {
            var randomStringList = new List<string>();

            for (var i = 0; i < numberOfStrings; i++)
            {
                randomStringList.Add(GenerateRandomString(stringLength, stringVariance));
            }

            return randomStringList;
        }

        public static string GenerateRandomString(int randomLettersCount, int variance = 0)
        {
            // for now
            // TODO: Add error handling for when variance is greater than random letters
            var random = new Random();

            if (variance > 0)
            {
                var randomVariant = random.Next(-variance, variance + 1);
                randomLettersCount = randomLettersCount + randomVariant;
            }

            var randomString = new StringBuilder();

            for (int i = 0; i < randomLettersCount; i++)
            {
                char randomLetter = (char)('a' + random.Next(0, 26));
                randomString.Append(randomLetter);
            }

            return randomString.ToString();

        }
    }
}
