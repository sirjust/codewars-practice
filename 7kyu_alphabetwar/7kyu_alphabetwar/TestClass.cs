using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit;
using NUnit.Framework;

namespace _7kyu_alphabetwar
{
    [TestFixture]
    public class AlphabetWarTest
    {
        [Test]
        public void BasicTest()
        {
            Assert.AreEqual("Right side wins!", Kata.AlphabetWar("z"));
            Assert.AreEqual("Let's fight again!", Kata.AlphabetWar("zdqmwpbs"));
            Assert.AreEqual("Right side wins!", Kata.AlphabetWar("zzzzs"));
            Assert.AreEqual("Left side wins!", Kata.AlphabetWar("wwwwwwz"));
        }
    }
}
