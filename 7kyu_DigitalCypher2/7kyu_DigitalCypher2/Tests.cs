using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7kyu_DigitalCypher2
{
    [TestFixture]
    public class Tests
    {
        [Test]
        public void BasicTest()
        {
            Assert.AreEqual("scout", Kata.Decode(new int[] { 20, 12, 18, 30, 21 }, 1939));
            Assert.AreEqual("masterpiece", Kata.Decode(new int[] { 14, 10, 22, 29, 6, 27, 19, 18, 6, 12, 8 }, 1939));
        }
    }
}
