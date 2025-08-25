namespace ConsoleApp1;

public static class CombinationFinder {
    public static IEnumerable<Combination> FindCombinations(string word, HashSet<string> repository, int maxParts) {
        for (var parts = 2; parts <= maxParts; parts++) {
            foreach (var splitParts in WordSplitter.SplitWord(word, parts)) {
                if (splitParts.All(repository.Contains)) {
                    yield return new Combination(splitParts, word);
                }
            }
        }
    }
}
