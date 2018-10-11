using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7th_kyu_roadbumps
{
    [TestFixture]
    class KataTest
    {
        [Test]
        public static void Test1()
        {
            Assert.AreEqual("Woohoo!", Kata.Bump("____nnnnnn_____nn__"));
        }

        [Test]
        public static void Test2()
        {
            Assert.AreEqual("Car Dead", Kata.Bump("_nnnnn_nnn_n_nnnnnn__nnnnn___nn__"));
        }
    }
}
