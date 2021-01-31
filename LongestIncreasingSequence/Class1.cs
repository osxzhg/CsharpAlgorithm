using System;

namespace LongestIncreasingSequence
{
    public class LongestIncreasingSequenceService
    {
        public static int LongestIncreasingSequence(int[] arr)
        {
            int n = arr.Length;
            int[] dp = new int[n];

            int maxLen = 0;
            for(int i = 0; i < n; i++)
            {
                int len = 1; 
                for(int j = 0; j < i; j++)
                {
                    if(arr[j]<arr[i])
                    {
                        len = Math.Max(len, dp[j] + 1);
                    }
                }

                dp[i] = len;
                if(dp[i]> maxLen)
                {
                    maxLen = dp[i];
                }
            }

            return maxLen;
        }

        
    }
}
