using System;
using Xunit;
using AlgoLib;

namespace TestAlgoLib
{
    public class StringProcessTests
    {
        public class GetCommonInStrings
        {
            [Theory]
            [InlineData(null, null)]
            [InlineData(null, "Hello")]
            [InlineData("Hello", null)]
            public void NullShouldThrowsArgumentNullException(string firstStr, string secondStr)
            {
                Exception exception = Record.Exception(() => StringProcess.GetCommonInStrings(firstStr, secondStr));

                Assert.IsType<ArgumentNullException>(exception);
            }

            [Theory]
            [InlineData("", "", "Hello")]
            [InlineData("", "Hello", "")]
            [InlineData("37", "15378", "67399")]
            [InlineData("73", "67399", "15378")]
            public void SentenceShouldBeReVersed(string outputSentence, string firstStr, string secondStr)
            {
                Assert.Equal(outputSentence, StringProcess.GetCommonInStrings(firstStr, secondStr));
            }
        }
	}
}
