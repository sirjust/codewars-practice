using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace _8kyu_2katas
{
    public class TestEnough
    {
        [TestFixture]
        public class SolutionTest
        {
            [Test]
            public void SampleTest()
            {
                Assert.AreEqual(0, Kata.Enough(10, 5, 5));
                Assert.AreEqual(10, Kata.Enough(100, 60, 50));
            }
        }
    }
}
