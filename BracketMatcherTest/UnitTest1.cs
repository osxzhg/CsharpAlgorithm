using System;
using Xunit;

namespace BracketMatcherTest
{
    public class UnitTest1
    {
        [Theory]
        [InlineData("(coder)(byte))",0)]
        [InlineData("(c(oder)) b(yte)",1)]
        public void Test1(string str1,int expected)
        {
            var result=BracketMatcher.BracketMatcherService.BracketMatcher(str1);
            Assert.Equal(expected, result);

        }
    }
}
