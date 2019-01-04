using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace _7kyu_MyLanguages
{
    [TestFixture, Description("MyLanguages")]
    public class TextFixture
    {
        [Test, Description("Fixed tests")]
        public void FixedTests()
        {
            Assert.That(Kata.MyLanguages(new Dictionary<string, int> { { "Java", 10 }, { "Ruby", 80 }, { "Python", 65 } }), Is.EqualTo((IEnumerable<string>)new string[] { "Ruby", "Python" }));
            Assert.That(Kata.MyLanguages(new Dictionary<string, int> { { "Hindi", 60 }, { "Greek", 71 }, { "Dutch", 93 } }), Is.EqualTo((IEnumerable<string>)new string[] { "Dutch", "Greek", "Hindi" }));
            Assert.That(Kata.MyLanguages(new Dictionary<string, int> { { "C++", 50 }, { "ASM", 10 }, { "Haskell", 20 } }), Is.EqualTo((IEnumerable<string>)new string[] { }));
        }
    }
}
