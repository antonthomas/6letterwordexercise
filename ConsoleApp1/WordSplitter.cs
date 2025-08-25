namespace ConsoleApp1;

public static class WordSplitter {
    public static IEnumerable<IEnumerable<string>> SplitWord(string word, int numberOfParts) {
        return SplitRecursive(word, numberOfParts);
    }

    private static IEnumerable<IEnumerable<string>> SplitRecursive(string word, int parts) {
        if (parts == 1) {
            yield return [word];
        }

        for (var i = 1; i < word.Length; i++) {
            var left = word[..i];
            foreach (var rest in SplitRecursive(word[i..], parts - 1)) {
                yield return new[] { left }.Concat(rest);
            }
        }
    }
}
