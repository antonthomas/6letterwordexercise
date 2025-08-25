namespace ConsoleApp1;

internal class Program {
    private const string FilePath = "./assets/input.txt";

    private static void Main(string[] args) {
        var words = FileReader.GetLines(FilePath);
        var repository = new HashSet<string>(words);

        var targetLength = 6;
        var maxParts = 3;

        var targetWords = words.Where(w => w.Length == targetLength);
        foreach (var word in targetWords) {
            var combinations = CombinationFinder.FindCombinations(word, repository, maxParts);

            foreach (var combination in combinations) {
                Console.WriteLine($"{string.Join('+', combination.Parts)}={combination.Word}");
            }
        }
    }
}


