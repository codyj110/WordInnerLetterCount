using WordInnerCharCount;
using Xunit;

namespace WordInnerCharCountTests
{
    public class SentenceServiceTests
    {
        [Fact]
        public void TransformsSenetence()
        {
            // setup
            var sentenceService = new SentenceService();
            var param = "Make sure to add plenty of words like warcraft-game and_moot!";
            var expected = "M2e s2e to a1d p4y of w3s l2e w4t-g2e a1d_m1t!";
            // act
            var result =sentenceService.TransformSentenceInnerCharCount(param);

            // assert
            Assert.Equal(expected, result);
        }
    }
}