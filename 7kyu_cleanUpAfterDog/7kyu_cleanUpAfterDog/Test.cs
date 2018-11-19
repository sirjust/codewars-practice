using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit;
using NUnit.Framework;

namespace _7kyu_cleanUpAfterDog
{
    [TestFixture]
    class Test
    {
        [Test]
        public void SampleTest()
        {
            Assert.AreEqual("Clean", Kata.Crap(new char[,] { { '_', '_', '_', '_' }, { '_', '_', '_', '@' }, { '_', '_', '@', '_' } }, 2, 2));
            Assert.AreEqual("Cr@p", Kata.Crap(new char[,] { { '_', '_', '_', '_' }, { '_', '_', '_', '@' }, { '_', '_', '@', '_' } }, 1, 1));
            Assert.AreEqual("Dog!!", Kata.Crap(new char[,] { { '_', '_' }, { '_', '@' }, { 'D', '_' } }, 2, 2));
        }
    }
}
