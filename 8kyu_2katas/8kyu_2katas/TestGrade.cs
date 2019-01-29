using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace _8kyu_2katas
{
    public class TestGrade
    {
        [TestFixture]
        public class Testing
        {
            [Test]
            public void FinalGradeTest()
            {
                Assert.AreEqual(Kata.FinalGrade(100, 12), 100);
                Assert.AreEqual(Kata.FinalGrade(85, 5), 90);
                Assert.AreEqual(Kata.FinalGrade(50, 2), 75);
                Assert.AreEqual(Kata.FinalGrade(0, 2), 0);
            }
        }
    }
}
