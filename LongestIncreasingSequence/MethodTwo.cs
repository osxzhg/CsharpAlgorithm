using System;
using System.Collections.Generic;
using System.Text;

namespace LongestIncreasingSequence
{
    public class MethodTwo
    {
        public static int LongestIncreasingSequence(int[] arr)
        {
            int n = arr.Length;
            int[] dp = new int[n];

            int maxLen = 0;
            foreach (int num in arr)
            {
                int index = Array.BinarySearch(dp, 0, maxLen, num);

                if(index < 0)
                {
                    index = -(index + 1);
                }

                dp[index] = num;

                if (index == maxLen)
                {
                    maxLen++;
                }
            }
            return maxLen;
        }

    }
}
