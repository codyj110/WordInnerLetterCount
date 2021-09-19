using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace WordInnerCharCount
{
    public class SentenceProcessor
    {
        public IEnumerable<string> GetWords(string sentence)
        {
            Regex rx = new Regex(@"[a-z]+", RegexOptions.IgnoreCase);
            var matches = rx.Matches(sentence);
            return matches.Select(m => m.Value).ToList();
        }

        public string ReplaceWords(Dictionary<string, string> wordsToReplace, string sentence)
        {
            foreach (var keyValuePair in wordsToReplace)
            {
                sentence = sentence.Replace(keyValuePair.Key, keyValuePair.Value);
            }

            return sentence;
        }
    }
}