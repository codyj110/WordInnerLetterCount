using System.Collections.Generic;
using System.Text.Json;
using WordInnerCharCount;
using Xunit;

namespace WordInnerCharCountTests
{
    public class SentenceProcessorTests
    {
        [Fact]
        public void ReturnsListOfWords()
        {
            // setup
            var processor = new SentenceProcessor();
            var param = "It took me too long to realize that the ceiling hadn't been painted to look like the sky.";
            // Separate all words by space or non alphabetic characters
            var expected = new List<string>()
            {
                "It", "took", "me", "too", "long", "to", "realize", "that", "the", "ceiling", "hadn", "t", "been","painted",
                "to", "look", "like", "the","sky"
            };
            var expectedJson = JsonSerializer.Serialize(expected);
            // act
            var result = processor.GetWords(param);
            var resultJson = JsonSerializer.Serialize(result);
            // assert
            Assert.Equal(expectedJson, resultJson);
        }
    }
}