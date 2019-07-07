using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using StringToNumber;

namespace Tests
{
    [TestFixture]
    public class StringToNumberTest
    {
        [Test]
        public void test1()
        {
            Assert.AreEqual(1234, Kata.StringToNumber("1234"));
        }

        [Test]
        public void test2()
        {
            Assert.AreEqual(605, Kata.StringToNumber("605"));
        }

        [Test]
        public void test3()
        {
            Assert.AreEqual(1405, Kata.StringToNumber("1405"));
        }

        [Test]
        public void test4()
        {
            Assert.AreEqual(-7, Kata.StringToNumber("-7"));
        }
    }
}
