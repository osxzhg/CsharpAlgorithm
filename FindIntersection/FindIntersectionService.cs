using System;
using System.Collections.Generic;
using System.Linq;

namespace FindIntersection
{
    public class FindIntersectionService
    {
        public static string FindIntersection(string[] strArr)
        {
            List<string> sList=ParseInput(strArr[0]);
            List<string> dList=ParseInput(strArr[1]);
            var result= sList.Intersect(dList);
            // code goes here  
            return result.Count()>0 ? string.Join(",", sList.Intersect(dList)) : "false";

        }

        public static List<string> ParseInput(string str)
        {
            return str.Split(',').Select(a => a.TrimStart()).ToList();
        }
    }
}
