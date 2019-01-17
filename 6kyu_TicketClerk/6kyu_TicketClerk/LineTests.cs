using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace _6kyu_TicketClerk
{
    [TestFixture]
    public class LineTests
    {
        [Test]
        public void Test1()
        {
            int[] peopleInLine = new int[] { 25, 25, 50, 50 };
            Assert.AreEqual("YES", Line.Tickets(peopleInLine));
        }

        [Test]
        public void Test2()
        {
            int[] peopleInLine = new int[] { 25, 100 };
            Assert.AreEqual("NO", Line.Tickets(peopleInLine));
        }
    }
}
