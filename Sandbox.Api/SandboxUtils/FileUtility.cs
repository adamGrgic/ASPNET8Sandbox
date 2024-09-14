namespace Sandbox.Api.SandboxUtils
{
    public static class FileUtility
    {
        public static void CreateTextFile(string name)
        {
            var currentDirectory = Directory.GetCurrentDirectory();
            var path = $"{currentDirectory}/tmp/{name}.txt";

            if (!File.Exists(path))
            {
                using (var streamWriter = File.CreateText(path))
                {
                    streamWriter.WriteLine("Hello");
                    streamWriter.WriteLine("And");
                    streamWriter.WriteLine("Welcome");
                }
            }
        }
    }
}
