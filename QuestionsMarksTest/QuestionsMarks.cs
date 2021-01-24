using System;
using Xunit;
using QuestionsMarks;

namespace QuestionsMarksTest
{
    public class QuestionsMarks
    {
        [Theory]
        [InlineData("acc?7??sss?3rr1??????5", "true")]
        public void Failed(string str1, string expected)
        {

            var result = QuestionsMardsService.QuestionsMarks(str1);
            Assert.Equal(expected, result);

        }
        [Theory]
        [InlineData("acc?7??sss?3rr1??????5", "true")]
        public void ForLoopMethod(string str1,string expected)
        {
            var result = QuestionsMardsService.UsingForLoop(str1);
            Assert.Equal(expected, result);
        }
    }
}
