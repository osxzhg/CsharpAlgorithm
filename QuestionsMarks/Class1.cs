using System;
using System.Collections.Generic;
using System.Linq;

namespace QuestionsMarks
{
    public class QuestionsMardsService
    {

        public static string QuestionsMarks(string str)
        {

            // code goes here 
            string findOneFlag="false";
            

            while (str != "NoNumberLeft" && str!="false")
            {
                
                str=FindNumberPairs(str,ref findOneFlag);
            }

            return findOneFlag;

        }

        public static string FindNumberPairs(string str,ref string findOneFlag)
        {
            Dictionary<char, char> NumberPair = new Dictionary<char, char>
            {
                ['1'] = '9',
                ['2'] = '8',
                ['3'] = '7',
                ['4'] = '6',
                ['5'] = '5',
                ['6'] = '4',
                ['7'] = '3',
                ['8'] = '2',
                ['9'] = '1',
            };

            if (str.Count(x => Char.IsDigit(x)) < 2) return "NoNumberLeft";

            // find the first number
            var firstNumber = str.FirstOrDefault(x => Char.IsDigit(x));

            //// If there are no number left, return NoNumbeLeft
            //if (!Char.IsDigit(firstNumber)) return "NoNumberLeft";

            // Get the indexof first number
            var indexOfFirstNumber = str.IndexOf(firstNumber);
            str=str.Substring(indexOfFirstNumber + 1);

            // Find the pair number, if can not find, return the left part
            var secondNumber = NumberPair[firstNumber];
            if (!str.Contains(secondNumber)) return str;

            // Check the number of '?' between the pair number
            var result = str.TakeWhile(x => x != secondNumber).Count(x => x == '?');

            // Return the left part
            if (result == 3)
            {
                findOneFlag = "true";
                return str.Substring(str.IndexOf(secondNumber));
            }
            return "false";
        }

        public static string UsingForLoop(string str)
        {
            int firstNum = 0;
            int secondNum = 0;
            int qmCount = 0;
            bool anyTens = false;

            for(int i = 0; i < str.Length; i++)
            {
                char current = str[i];
                if (Char.IsDigit(str[i]))
                {
                    if (firstNum == 0)
                    {
                        firstNum = str[i];
                        qmCount = 0;
                    }
                    else
                    {
                        secondNum = str[i];
                        if (firstNum + secondNum == 106)
                        {
                            if (qmCount == 3)
                            {
                                anyTens = true;
                                firstNum = secondNum;
                                qmCount = 0;
                            }
                            else
                            {
                                return "false";
                            }
                        }
                    }
                }
                else if (str[i] == '?')
                {
                    qmCount++;
                }

            }
            return anyTens ? "true" : "false";
        }
        

    }
}
