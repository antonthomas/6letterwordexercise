namespace ConsoleApp1;

public static class FileReader {
    public static IEnumerable<string> GetLines(string filePath) {
        return File
            .ReadAllLines(filePath)
            .Select(w => w.Trim())
            .Where(w => !string.IsNullOrEmpty(w));
    }
}
