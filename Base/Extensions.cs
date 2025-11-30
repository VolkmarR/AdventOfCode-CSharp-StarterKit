namespace AdventOfCode.Base;

static class Extensions
{
    extension(IEnumerable<string> strings)
    {
        public string Join(string separator)
            => string.Join(separator, strings);
    }

    extension<T>(Dictionary<T, int> countDictionary)
    {
        public void IncrementCount(T key)
        {
            countDictionary.TryGetValue(key, out var current);
            countDictionary[key] = ++current;
        }
    }

    extension<T>(Dictionary<T, long> countDictionary)
    {
        public void IncrementCount(T key)
        {
            countDictionary.TryGetValue(key, out var current);
            countDictionary[key] = ++current;
        }
    }

    extension(string text)
    {
        public string[] Split(StringSplitOptions stringSplitOptions, params char[] separators)
            => text.Split(separators, stringSplitOptions);

        public string[] Split(params char[] separators)
            => text.Split(separators);

        public string[] Split(StringSplitOptions stringSplitOptions, params string[] separators)
            => text.Split(separators, stringSplitOptions);

        public List<string> ToList() => new() { text };
        public int ToInt() => int.Parse(text);
        public long ToLong() => long.Parse(text);
    }
}