using System;
using Xunit;
using LongestIncreasingSequence;

namespace LengthOfLISTest
{
    public class UnitTest1
    {
        [Theory]
        [InlineData(4,new int[] { 10, 9, 2, 5, 3, 7, 101, 18 })]
        public void Test1(int expected,int[] nums)
        {
            var result = LongestIncreasingSequenceService.LongestIncreasingSequence(nums);
            Assert.Equal(expected, result);

        }
    }
}
