internal static class FileReader
{
    private const string FilePath = @"C:\tmp\data.txt";

    // Reads and returns the contents of the configured text file.
    internal static string ReadFile()
    {
        return File.ReadAllText(FilePath);
    }
}