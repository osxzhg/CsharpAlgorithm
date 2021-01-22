using System;
using System.Collections.Generic;

namespace BracketMatcher
{
    public class BracketMatcherService
    {
        public static int BracketMatcher(string str)
        {
            Stack<char> stack = new Stack<char>();
            foreach (var item in str)
            {
                if (item == '(')
                {
                    stack.Push('(');
                }
                else if (item == ')')
                {
                    if (stack.Count == 0)
                    {
                        return 0;
                    }
                    else
                    {
                        stack.Pop();
                    }
                }
            }
            return stack.Count == 0 ? 1 : 0;
        }
    }
}
