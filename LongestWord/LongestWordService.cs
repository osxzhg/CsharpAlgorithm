using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace LongestWord
{
    public class LongestWordService
    {
        public static string LongestWord(string sen)
        {
            string[] sArr = Regex.Replace(sen, @"[^a-zA-Z0-9\s]", string.Empty).Split(" ");
            var maxLength = sArr.Max(x => x.Length);
            var result = sArr.First(x => x.Length == maxLength);

            // code goes here  
            return result;

        }
        public static string Reverse(string str)
        {
            return new string(str.Reverse().ToArray());
        }
    }
}
