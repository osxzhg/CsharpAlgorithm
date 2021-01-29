using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using QuestionsMarks;

namespace QuestionsMarksTest
{
    public class MethodTwoQuestionsMarks
    {
        [Theory]
        [InlineData("acc?7??sss?3rr1??????5", "true")]
        public void Success(string str1, string expected)
        {

            var result = MethodTwo.QuestionsMarks(str1);
            Assert.Equal(expected, result);

        }
        [Theory]
        [InlineData("9???1???9??1???9", "true")]
        public void OneNumberUseTwice(string str1, string expected)
        {

            var result = MethodTwo.QuestionsMarks(str1);
            Assert.Equal(expected, result);

        }

        [Theory]
        [InlineData("9???23???7", "false")]
        public void SumIsNotTen(string str1, string expected)
        {

            var result = MethodTwo.QuestionsMarks(str1);
            Assert.Equal(expected, result);

        }
    }
}
