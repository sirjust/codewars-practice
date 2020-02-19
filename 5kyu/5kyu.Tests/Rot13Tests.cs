using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using Rot13;

namespace _5kyu.Tests
{
    [TestFixture]
    public class Rot13Tests
    {
        [Test, Description("test")]
        public void testTest()
        {
            Assert.AreEqual("grfg", Kata.Rot13("test"), String.Format("Input: test, Expected Output: grfg, Actual Output: {0}", Kata.Rot13("test")));
        }

        [Test, Description("Test")]
        public void TestTest()
        {
            Assert.AreEqual("Grfg", Kata.Rot13("Test"), String.Format("Input: Test, Expected Output: Grfg, Actual Output: {0}", Kata.Rot13("Test")));
        }

        [Test, Description("Test")]
        public void AnotherTest()
        {
            Assert.AreEqual("10+2 vf gjryir.", Kata.Rot13("10+2 is twelve."));
        }

        [Test, Description("Test")]
        public void YetAnotherTest()
        {
            Assert.AreEqual("nopqrstuvwxyzabcdefghijklm", Kata.Rot13("abcdefghijklmnopqrstuvwxyz"));
        }
    }
}
