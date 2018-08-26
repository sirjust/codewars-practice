using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace _7kyu_InspiringStringsWithTests
{
    class NUnitTestClass
    {
        [TestFixture]
        public class SolutionTest
        {

            private static object[] Basic_Test_Cases = new object[]
            {
      new object[] {"a b c d e fgh", "fgh"},
      new object[] {"one two three", "three"},
      new object[] {"red blue grey", "grey"},
            };

            [Test, TestCaseSource(typeof(SolutionTest), "Basic_Test_Cases")]
            public void Basic_Test(string test, string expected)
            {
                Assert.AreEqual(expected, Class1.LongestWord(test));
            }

            // Note: Random tests output user code execution time
        }
    }
}
