using System;

namespace WordInnerCharCount
{
    class Program
    {
        static void Main(string[] args)
        {
            var wordService = new SentenceService();
            
            Console.WriteLine("Please Enter a sentence.");
            var input = Console.ReadLine();

            var newSentence = wordService.TransformSentenceInnerCharCount(input);
            
            Console.WriteLine(newSentence);
        }
    }
}