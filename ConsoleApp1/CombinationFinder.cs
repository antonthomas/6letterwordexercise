namespace ConsoleApp1;

public static class CombinationFinder {
    public static List<Combination> FindCombinations(string word, HashSet<string> repository, int maxParts) {
        var results = new List<Combination>();

        for (var parts = 2; parts <= maxParts; parts++) {
            foreach (var splitParts in WordSplitter.SplitWord(word, parts)) {
                if (splitParts.All(repository.Contains)) {
                    results.Add(new Combination(splitParts, word));
                }
            }
        }

        return results;
    }
}
