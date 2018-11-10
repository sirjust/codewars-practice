using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace firstNonRepeatingLetter
{
    [TestFixture]
    public class KataTest
    {
        [Test]
        public void BasicTests()
        {
            Assert.AreEqual("a", Kata.FirstNonRepeatingLetter("a"));
            Assert.AreEqual("t", Kata.FirstNonRepeatingLetter("stress"));
            Assert.AreEqual("e", Kata.FirstNonRepeatingLetter("moonmen"));
            Assert.AreEqual("T", Kata.FirstNonRepeatingLetter("STress"));
            Assert.AreEqual("!", Kata.FirstNonRepeatingLetter("!stress"));
        }
    }
}
