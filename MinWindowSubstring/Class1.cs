using System;
using System.Collections.Generic;
using System.Linq;

namespace MinWindowSubstring
{
    public class Class1
    {
        public static Dictionary<char, int> StrToDictionary(string s)
        {
            return s.ToCharArray().GroupBy(c => c).ToDictionary(c => c.Key, c => c.Count());
        }

        public static bool LoopDictionaryByKey(Dictionary<char, int> dic, string str)
        {

            foreach (KeyValuePair<char, int> item in dic)
            {
                if (str.Count(x => x == item.Key) < item.Value)
                {
                    return false;
                }
            }
            return true;
        }

        public static string ForwordSearch(string str1, string str2)
        {
            Dictionary<char, int> targetDictionary = StrToDictionary(str2);
            string forwordSearchResult = null;

            for (int i = 0; i < str1.Length; i++)
            {
                string sourceStr = str1.Substring(0, i + 1);
                if (LoopDictionaryByKey(targetDictionary, sourceStr))
                {
                    forwordSearchResult = sourceStr;
                    break;
                }

            }

            return forwordSearchResult;
        }
        public static string BackwordSearch(string str1, string str2)
        {
            Dictionary<char, int> targetDictionary = StrToDictionary(str2);
            string backwordSearchResult = null;
            for (int i = 0; i < str1.Length; i++)
            {
                string sourceStr = str1.Substring(str1.Length - i - 1, i + 1);
                if (LoopDictionaryByKey(targetDictionary, sourceStr))
                {
                    backwordSearchResult = sourceStr;
                    break;
                }

            }
            return backwordSearchResult;
        }
        public static string MinWindowSubstring(string[] strArr)
        {
            string str1 = strArr[0];
            string str2 = strArr[1];
            string forwordSearch = ForwordSearch(str1, str2);
            return BackwordSearch(forwordSearch, str2);
        }

        public static string ZipStringByNumber(string str, int n)
        {
            string result;
            if (n > 0)
            {
                result = str.Substring(0, str.Length - n);
            }
            else if (n < 0)
            {
                result = str.Substring(-n, str.Length + n);
            }
            else
            {
                result = str;
            }
            return result;
        }
    }
}
