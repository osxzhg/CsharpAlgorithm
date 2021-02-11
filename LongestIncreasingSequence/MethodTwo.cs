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
            // int[] lastNum = new int[n];
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
                // if (index > 0) { lastNum[index] = dp[index - 1]; }

                if (index == maxLen)
                {
                    
                    
                    maxLen++;
                }
            }
            return maxLen;
        }

        public static int[] LongestIncreasingSequenceArray(int[] arr)
        {
            int n = arr.Length;
            Dictionary<int,int> last=new Dictionary<int, int>();
            int[] dp = new int[n];

            int maxLen = 0;
            for(int i=0;i<arr.Length;i++)
            {
                int num=arr[i];
                    int index = Array.BinarySearch(dp, 0, maxLen, num);

                if (index < 0)
                {
                    index = -(index + 1);
                }

                

                //lastNum[i]=dp[index-1];
                dp[index] = num; 
                if (index>0){last.Add(num,dp[index-1]);}

                // if (index > 0) { lastNum[index] = dp[index - 1]; }
                
                if (index == maxLen)
                {
                    maxLen++;
                }
            }

            Stack<int> result=new Stack<int>();
            result.Push(dp[maxLen-1]);
            var current=dp[maxLen-1];

            for (int i = 1; i < maxLen; i++)
            {
                current=last[current];
                result.Push(current);
            }

            // result[maxLen-1] = dp[maxLen-1];

            return result.ToArray();
        }

    }
}
