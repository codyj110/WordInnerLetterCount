using WordInnerCharCount;
using Xunit;

namespace WordInnerCharCountTests
{
    public class WordTransformerTests
    {
        [Fact]
        public void CountsInnerCharLetters()
        {
            // setup
            var wordTransformer = new WordTransformer();
            var param = "Toothy";
            var expected = "T3y";

            // act
            var result = wordTransformer.InnerCharCount(param);

            // assert
            Assert.Equal(expected, result);
        }
    }
}