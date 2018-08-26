using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace _7kyu_ProductArray
{
    class NUnitTestClass
    {
        [TestFixture]
        class Tests
        {
            [TestCase("12 20", "20 12")]
            [TestCase("3 27 4 2", "216 24 162 324")]
            [TestCase("13 10 5 2 9", "900 1170 2340 5850 1300")]
            [TestCase("16 17 4 3 5 2", "2040 1920 8160 10880 6528 16320")]
            [TestCase("-1 30 1", "30 -1 -30")]
            [TestCase("0 10 3", "30 0 0")]
            public void BasicTest(string s, string str)
            {
                Assert.That(Program.ProductArray(Foo(s)), Is.EqualTo(Foo(str)));
            }
            int[] Foo(string s) => s.Split().Select(int.Parse).ToArray();
        }
    }
}
