using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace QuestionsMarks
{
    public class MethodTwo
    {
        // replace all character to empty, except numbers and question marks
        // find all d???d, each character use once
        // check find at least one 
        // check each of sum of two is 10
        public static string QuestionsMarks(string str)
        {
            string polished = Regex.Replace(str, @"[^\d\?]", string.Empty);
            var matches = Regex.Matches(polished, @"([\d]{1}[\?]{3}[\d]{1})");
            var results = new List<int>();

            foreach (Match m in matches)
            {
                //int a = Convert.ToInt32(m.Value.First().ToString());
                int a = Convert.ToInt32(m.Value.First().ToString()); // char to int will get the unicode
                int b = Convert.ToInt32(m.Value.Last().ToString()); // string to int will get the decimal

                results.Add(a + b);
            }

            string result = results.Count != 0 && results.All(r => r == 10) ? "true" : "false";
            return result;
        }
    }
}
