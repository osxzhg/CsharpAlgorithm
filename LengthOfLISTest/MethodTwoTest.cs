using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using LongestIncreasingSequence;

namespace LengthOfLISTest
{
    public class MethodTwoTest
    {
        [Theory]
        [InlineData(4, new int[] { 10, 9, 2, 5, 3, 7, 101, 18 })]
        public void Test1(int expected, int[] nums)
        {
            var result = MethodTwo.LongestIncreasingSequence(nums);
            Assert.Equal(expected, result);

        }

        [Theory]
        [InlineData(8, new int[] { 100, 101, 102,105, 2,3,4,90,91,92,93,94 })]
        public void LargeNumberBeforeSmallNumbers(int expected, int[] nums)
        {
            var result = MethodTwo.LongestIncreasingSequence(nums);
            Assert.Equal(expected, result);

        }
    }
}

