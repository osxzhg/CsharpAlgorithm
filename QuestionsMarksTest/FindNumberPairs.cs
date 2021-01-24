using QuestionsMarks;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace TestProject
{
    public class FindNumberPairs
    {
        [Theory]
        [InlineData("acc?7??sss?3rr1??????5", "3rr1??????5")]
        public void FindNumberPairsReturnLeft(string str1, string expected)
        {
            string findOneFlag = "false";

            var result = QuestionsMardsService.FindNumberPairs(str1,ref findOneFlag);
            Assert.Equal(expected, result);
            Assert.Equal("true",findOneFlag);

        }
        [Theory]
        [InlineData("3rr1??????5", "rr1??????5")]
        public void NotFindNumberPairs(string str1, string expected)
        {
            string findOneFlag = "false";
            var result = QuestionsMardsService.FindNumberPairs(str1,ref findOneFlag);
            Assert.Equal(expected, result);

        }
        [Theory]
        [InlineData("3rr1??????7", "false")]
        public void NotThreeQuestionMarks(string str1, string expected)
        {
            string findOneFlag = "false";
            var result = QuestionsMardsService.FindNumberPairs(str1, ref findOneFlag);
            Assert.Equal(expected, result);

        }
        [Theory]
        //[InlineData("rr??????", "NoNumberLeft")]
        [InlineData("??????5","NoNumberLeft")]
        public void NoNumberLeft(string str1, string expected)
        {
            string findOneFlag = "false";
            var result = QuestionsMardsService.FindNumberPairs(str1, ref findOneFlag);
            Assert.Equal(expected, result);

        }
    }
}
