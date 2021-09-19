using System.Collections.Generic;
using System.Linq;

namespace WordInnerCharCount
{
    public class SentenceService
    {
        private readonly SentenceProcessor _sentenceProcessor = new();
        private readonly WordTransformer _wordTransformer = new();

        public string TransformSentenceInnerCharCount(string sentence)
        {
            var words = _sentenceProcessor.GetWords(sentence);

            var wordReplacementDict = CreateReplacementDictionary(words);

            return _sentenceProcessor.ReplaceWords(wordReplacementDict, sentence);
        }

        private Dictionary<string, string> CreateReplacementDictionary(IEnumerable<string> words)
        {
            var wordReplacementDict = new Dictionary<string, string>();
            ProcessWords(words, wordReplacementDict);

            return wordReplacementDict;
        }

        private void ProcessWords(IEnumerable<string> words, Dictionary<string, string> wordReplacementDict)
        {
            foreach (var word in words)
            {
                ProcessWord(wordReplacementDict, word);
            }
        }

        private void ProcessWord(Dictionary<string, string> wordReplacementDict, string word)
        {
            if (WordNeedsProcessed(wordReplacementDict, word))
            {
                var transformedWord = _wordTransformer.InnerCharCount(word);
                wordReplacementDict.Add(word, transformedWord);
            }
        }

        private static bool WordNeedsProcessed(Dictionary<string, string> wordReplacementDict, string word)
        {
            return WordDoesNotExistInDictionary(wordReplacementDict, word) && word.Count() > 2;
        }

        private static bool WordDoesNotExistInDictionary(Dictionary<string, string> wordReplacementDict, string word)
        {
            return !wordReplacementDict.ContainsKey(word);
        }
    }
}