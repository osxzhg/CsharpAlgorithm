using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using LongestIncreasingSequence;

namespace LengthOfLISTest
{
    public class MethodTwoTest
    {
        [Theory(DisplayName ="ok")]
        [InlineData(4, new int[] { 10, 9, 2, 5, 3, 7, 101, 18 })]
        public void TestOk(int expected, int[] nums)
        {
            var result = MethodTwo.LongestIncreasingSequence(nums);
            Assert.Equal(expected, result);

        }

        [Theory]
        [InlineData(8, new int[] { 100, 101, 102, 105, 2, 3, 4, 90, 91, 92, 93, 94 })]
        public void LargeNumberBeforeSmallNumbers(int expected, int[] nums)
        {
            var result = MethodTwo.LongestIncreasingSequence(nums);
            Assert.Equal(expected, result);

        }
        [Theory]
        [InlineData(8, new int[] { 2, 3, 4, 90, 91, 92, 93, 94 }, new int[] { 100, 101, 102, 105, 2, 3, 4, 90, 91, 92, 93, 94 })]
        public void LisArray(int dummy, int[] expected, int[] nums)
        {
            var result = MethodTwo.LongestIncreasingSequenceArray(nums);
            Assert.Equal(expected, result);

        }

        [Theory]
        [InlineData(8, new int[] { 0, 2, 6, 9, 11, 15 }, new int[] { 0, 8, 4, 12, 2, 10, 6, 14, 1, 9, 5, 13, 3, 11, 7, 15 })]
        public void LisArrayWithZero(int dummy, int[] expected, int[] nums)
        {
            var result = MethodTwo.LongestIncreasingSequenceArray(nums);
            Assert.Equal(expected, result);

        }

        [Theory]
        [InlineData(8, new int[] { 2, 6, 9, 11 }, new int[] { 8, 4, 12, 2, 10, 6, 14, 1, 9, 5, 13, 3, 11, 7 })]
        public void LisArrayWithDebug(int dummy, int[] expected, int[] nums)
        {
            var result = MethodTwo.LongestIncreasingSequenceArray(nums);
            Assert.Equal(expected, result);

        }
    }
}

