namespace ConsoleApp1;

public static class CombinationFinder {
    public static IEnumerable<Combination> FindCombinations(string word, HashSet<string> repository, int maxParts) {
        for (var parts = 2; parts <= maxParts; parts++) {
            var validSplits = WordSplitter.SplitWord(word, parts).Where(s => s.All(repository.Contains));

            foreach (var validSplitParts in validSplits) {
                yield return new Combination(validSplitParts, word);
            }
        }
    }
}
