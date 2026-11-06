internal static class Program
{
	// Starts the application and prints the configured file contents.
	private static void Main()
	{
		try
		{
			Console.Write(FileReader.ReadFile());
		}
		catch (IOException exception)
		{
			Console.Error.WriteLine($"讀取檔案失敗：{exception.Message}");
			Environment.ExitCode = 1;
		}
		catch (UnauthorizedAccessException exception)
		{
			Console.Error.WriteLine($"沒有權限讀取檔案：{exception.Message}");
			Environment.ExitCode = 1;
		}
	}
}
