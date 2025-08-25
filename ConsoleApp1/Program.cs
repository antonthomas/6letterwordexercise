namespace ConsoleApp1;

internal class Program {
    private const string FilePath = "./assets/input.txt";
    private const int TargetLength = 6;
    private const int MaxParts = 3;

    private static void Main(string[] args) {
        var words = FileReader.GetLines(FilePath);
        var repository = new HashSet<string>(words);

        var targetWords = words.Where(w => w.Length == TargetLength);
        foreach (var word in targetWords) {
            var combinations = CombinationFinder.FindCombinations(word, repository, MaxParts);

            foreach (var combination in combinations) {
                Console.WriteLine($"{string.Join('+', combination.Parts)}={combination.Word}");
            }
        }
    }
}


