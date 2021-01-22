using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace BinaryTreeCreate
{
    public class TreeConstructor
    {
        public static string[] ParseInput(string str)
        {
            string[] outStr = Regex.Replace(str, @"[^\d,]", string.Empty).Split(',');
            return outStr;
        }

        public static bool Check(string str,Dictionary<string,int> dic,int max)
        {
            if (dic.ContainsKey(str))
            {
                dic[str]++;
                if (dic[str] > max)
                    return false;
                else
                    return true;
            }
            else
            {
                dic.Add(str, 1);
                return true;
            }
        }

        public static string CreateTree(string[] strArr)
        {
            Dictionary<string, int> ChildDictionary = new Dictionary<string, int>();
            Dictionary<string, int> ParentDictionary = new Dictionary<string, int>();

            foreach(var item in strArr)
            {
                string[] sStr=ParseInput(item);
                if (!Check(sStr[0], ChildDictionary, 1)) return "false";
                if (!Check(sStr[1], ParentDictionary, 2)) return "false";
            }
            return "true";
        }
    }
}
