using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace _7kyu_vowel_harmonization
{
    [TestFixture]
    public class TestKata
    {
        [Test]
        public void ExampleTests()
        {
            Assert.AreEqual("ablaknak", Kata.Dative("ablak"));
            Assert.AreEqual("tükörnek", Kata.Dative("tükör"));
            Assert.AreEqual("keretnek", Kata.Dative("keret"));
            Assert.AreEqual("otthonnak", Kata.Dative("otthon"));
            Assert.AreEqual("virágnak", Kata.Dative("virág"));
            Assert.AreEqual("tettnek", Kata.Dative("tett"));
            Assert.AreEqual("rokkantnak", Kata.Dative("rokkant"));
            Assert.AreEqual("rossznak", Kata.Dative("rossz"));
            Assert.AreEqual("gonosznak", Kata.Dative("gonosz"));
        }
    }
}
