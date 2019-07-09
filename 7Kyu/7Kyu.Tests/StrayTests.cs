using NUnit.Framework;
using Stray;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7Kyu.Tests
{
    [TestFixture]
    public class StrayTests
    {
        [Test]
        public void SimpleArray1()
        {
            Assert.AreEqual(2, Kata.Stray(new int[] { 1, 1, 2 }));
        }
    }
}
