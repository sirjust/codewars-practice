using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using AverageArray;

namespace _7Kyu.Tests
{
    class AverageArrayTests
    {
        [TestFixture]
        public class SolutionTest
        {
            [Test]
            public void SampleTest()
            {
                Assert.AreEqual(new double[] { 3, 4, 5, 6 }, Kata.AvgArray(new double[][] { new double[] { 1, 2, 3, 4 }, new double[] { 5, 6, 7, 8 } }));
                Assert.AreEqual(new double[] { 22.5, 11, 38.75, 38.25, 19.5 }, Kata.AvgArray(new double[][] { new double[] { 2, 3, 9, 10, 7 }, new double[] { 12, 6, 89, 45, 3 }, new double[] { 9, 12, 56, 10, 34 }, new double[] { 67, 23, 1, 88, 34 } }));
            }
        }
    }
}
