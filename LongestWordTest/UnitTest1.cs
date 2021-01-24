using System;
using Xunit;
using LongestWord;

namespace LongestWordTest
{
    public class UnitTest1
    {
        [Theory]
        [InlineData("123456789 98765432", "123456789")]
        public void Test1(string str1,string expected)
        {
            var result = LongestWordService.LongestWord(str1);
            Assert.Equal(expected, result);

        }
        [Theory]
        [InlineData("coderbyte", "etybredoc")]
        public void ReverseTest(string str1, string expected)
        {
            var result = LongestWordService.Reverse(str1);
            Assert.Equal(expected, result);

        }
    }
}
