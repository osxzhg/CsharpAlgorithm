using BinaryTreeCreate;
using System;
using System.Collections.Generic;
using Xunit;

namespace BinaryTreeCreateTest
{
    public class UnitTest1
    {
        [Theory]
        [InlineData("(1,2)", new string[2]{"1","2"})]
        [InlineData("(2,4)", new string[2]{"2","4"})]
        public void ParseInputTest(string str, string[] expected)
        {
            var result = TreeConstructor.ParseInput(str);
            Assert.Equal(expected[0], result[0]);
            Assert.Equal(expected[1], result[1]);
        }
        [Theory]
        [InlineData("1",1,false)]
        [InlineData("2",1,false)]
        [InlineData("7",1,false)]
        [InlineData("3",1,true)]
        [InlineData("1",2,true)]
        public void CheckTest(string op,int count,bool expected)
        {
            Dictionary<string, int> targetDictionary = new Dictionary<string, int>();
            targetDictionary.Add("1",1 );
            targetDictionary.Add("2",1 );
            targetDictionary.Add("7",1 );
            var result = TreeConstructor.Check(op,targetDictionary,count);
            Assert.Equal(expected,result);
        }
        [Theory]
        [InlineData("true", new string[] { "(1,2)", "(2,4)", "(5,7)", "(7,2)", "(9,5)" })]
        [InlineData("false", new string[] { "(1,2)", "(3,2)", "(2,12)", "(5,2)" })]
        public void ServiceTest(string expected,string[] strArr)
        {
            var result= TreeConstructor.CreateTree(strArr);
            Assert.Equal(expected,result);

        }
    }
}
