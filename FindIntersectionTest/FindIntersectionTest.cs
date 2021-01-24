using System;
using Xunit;
using FindIntersection;
using System.Linq;
using System.Collections.Generic;

namespace TestProject
{
    public class FindIntersectionTest
    {
        [Theory]
        [InlineData("1,3,4,7,13")]
        public void Test1(string str)
        {

            var result = FindIntersectionService.ParseInput(str);
            Assert.Equal("1", result.ElementAt(0));
            Assert.Equal("3", result.ElementAt(1));
        }
        [Theory]
        [InlineData("1,3,4,7,13", "1, 2, 4, 13, 15", "1,4,13")]
        [InlineData("1, 3, 9, 10, 17, 18", "1, 4, 9, 10", "1,9,10")]
        [InlineData("1, 3, 9, 10, 17, 18", "2", "false")]
        public void FindIntersection(string str1,string str2,string expected)
        {
            string[] input = new string[2] { str1, str2 };

            var result = FindIntersectionService.FindIntersection(input);
            Assert.Equal(expected, result);
            List<string> stringE = new List<string>();
            stringE.Add("abc");
            stringE.Add("bcd");
            var test = stringE.ToString();
            Console.WriteLine(test);

        }
    }
}
