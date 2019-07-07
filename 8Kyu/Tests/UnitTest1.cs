using System;
using NUnit.Framework;
using CountOddNumbersBelowN;

namespace Tests
{
    [TestFixture]
    public class SampleTest
    {
        [Test]
        public void Test()
        {
            Assert.AreEqual(7, Kata.OddCount(15));
            Assert.AreEqual(7511, Kata.OddCount(15023));
        }
    }
}

