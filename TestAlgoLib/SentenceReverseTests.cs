using System;
using Xunit;
using AlgoLib;

namespace TestAlgoLib
{
    public class SentenceReverseTests
    {
        public class GetReversedSentenceShould
        {
            [Fact]
            public void NullShouldReturnNull()
            {
                Assert.Equal(null, SentenceReverse.GetReversedSentence(null));
            }

            [Fact]
            public void EmptyShouldReturnEmpty()
            {
                Assert.Equal("", SentenceReverse.GetReversedSentence(""));
            }

            [Theory]
            [InlineData("Hello", "Hello")]
            [InlineData("World Hello", "Hello World")]
            [InlineData("World  Hello", "Hello  World")]
            [InlineData("test simple a Just", "Just a simple test")]
            public void SentenceShouldBeReVersed(string outputSentence, string inputSentence)
            {
                Assert.Equal(outputSentence, SentenceReverse.GetReversedSentence(inputSentence));
            }

        }
    }
}
