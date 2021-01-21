using Xunit;
using MinWindowSubstring;

namespace MinWindowSubstringTest
{
    public class UnitTest1
    {
            [Theory]
            [InlineData("ahffaksfajeeubsne", "jefaa", "ahffaksfaje")]
            //[InlineData("abab", "bb", "abab")]
            public void Test1(string str1, string str2, string expected)
            {
                string[] inputStr = new string[2] { str1, str2 };
                string result = Class1.ForwordSearch(str1, str2);
                Assert.Equal(expected, result);
            }

            [Theory]
            //[InlineData("ahffaksfajeeubsne", "jefaa", "aksfaje")]
            [InlineData("ahffaksfaje", "jefaa", "aksfaje")]
            public void Test2(string str1, string str2, string expected)
            {
                string[] inputStr = new string[2] { str1, str2 };
                string result = Class1.BackwordSearch(str1, str2);

                Assert.Equal(expected, result);

            }
            [Theory]
            [InlineData("ahffaksfajeeubsne", "jefaa", "aksfaje")]
            [InlineData("aaffhkksemckelloe", "fhea", "affhkkse")]
            public void Test3(string str1, string str2, string expected)
            {
                var result = Class1.MinWindowSubstring(new string[2] { str1, str2 });
                Assert.Equal(expected, result);
            }
            [Theory]
            //[InlineData("ahffaksfajeeubsne")]
            [InlineData("aa")]
            public void StringToDictionaryTest(string str)
            {
                var result = Class1.StrToDictionary(str);
                //Assert.Equal(3, result['a']);
                //Assert.Equal(1, result['h']);
                //Assert.Equal(3, result['f']);
                var ret = Class1.LoopDictionaryByKey(result, "aba");
                Assert.True(ret);
            }
            [Theory]
            //[InlineData("ahffaksfajeeubsne")]
            //[InlineData("aaafs",1,"aaaf")]
            [InlineData("aaafs", 2, "aaa")]
            [InlineData("aaafs", -1, "aafs")]
            [InlineData("aaafs", -2, "afs")]
            public void ZipStringByNumberTest(string str, int n, string expected)
            {

                var result = Class1.ZipStringByNumber(str, n);
                Assert.Equal(expected, result);
            }

    }
}
