using System.Linq;

namespace WordInnerCharCount
{
    public class WordTransformer
    {
        public string InnerCharCount(string word)
        {
            var first = ExtractFirst(word);
            word = RemoveFirstChar(word);
            var last = ExtractLast(word);
            word = RemoveLastChar(word);
            
            var charCount = GetDistinctCharCount(word);

            return $"{first}{charCount}{last}";
        }

        private static int GetDistinctCharCount(string word)
        {
            var distinctChars = word.Distinct();
            var charCount = distinctChars.Count();
            return charCount;
        }

        private static char ExtractLast(string word)
        {
            return word[^1];
        }

        private static string RemoveLastChar(string word)
        {
            return word.Remove(word.Length - 1);
        }

        private static char ExtractFirst(string word)
        {
            return word[0];
        }

        private static string RemoveFirstChar(string word)
        {
            return word.Remove(0, 1);
        }
    }
}