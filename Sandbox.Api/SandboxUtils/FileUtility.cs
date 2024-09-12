namespace Sandbox.Api.SandboxUtils
{
    public static class FileUtility
    {
        public static void CreateTextFile(string name)
        {
            var currentDirectory = Directory.GetCurrentDirectory();
            File.CreateText($"{currentDirectory}/tmp/{name}.txt");
        }
    }
}
