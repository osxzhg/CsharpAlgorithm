using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;

namespace CheckUsername
{
    public class ValidateService
    {
        public static bool CodelandUsernameValidation(string str)
        {
            var criteria= new List<Func<string, bool>>();
            Func<string, bool> CheckLength = (x) => x.Length >= 4 && x.Length <= 25;
            Func<string, bool> CheckFirstLetter = (x) => char.IsLetter(x[0]);
            Func<string, bool> CheckOtherLetters = (x) =>
            {
                List<char> dataList = new List<char>();
                dataList.AddRange(x.Substring(1, x.Length - 1));
                return dataList.All(y => Char.IsLetterOrDigit(y) || y == '_');
            };
            Func<string, bool> CheckLastLetter = (x) => x[x.Length-1]!='_';


            criteria.Add(CheckLength);
            criteria.Add(CheckFirstLetter);
            criteria.Add(CheckOtherLetters);
            criteria.Add(CheckLastLetter);

            foreach(var item in criteria)
            {
                if (!item(str)) return false;
            }
            return true;
        }
    }
}
