using System;
using Xunit;
using CheckUsername;

namespace CheckUsernameTest
{
    public class UnitTest1
    {
        [Theory]
        [InlineData("abcd",true)]
        [InlineData("abc",false)]
        [InlineData("abcdefghijklmnopqrstuvwxyz",false)]
        [InlineData("1abc",false)]
        [InlineData("_abc",false)]
        [InlineData("a%bc",false)]
        [InlineData("a1bc_",false)]
        public void Test1(string str,bool expected)
        {
            var result=ValidateService.CodelandUsernameValidation(str);
            Assert.Equal(expected, result);
        }
    }
}
