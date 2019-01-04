using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8kyu_banjo
{
    class TestKata
    {
    [TestFixture]
        public class AreYouPlayingBanjo
        {
            [Test]
            public static void Martin()
            {
                Assert.AreEqual("Martin does not play banjo", Kata.AreYouPlayingBanjo("Martin"));
            }

            [Test]
            public static void Rikke()
            {
                Assert.AreEqual("Rikke plays banjo", Kata.AreYouPlayingBanjo("Rikke"));
            }
        }
    }
}
