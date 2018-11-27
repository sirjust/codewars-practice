using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6kyu_areTheySame
{
    [TestFixture]
    public class AreTheySame_Test
    {

        [Test]
        public void Test1()
        {
            int[] a = new int[] { 121, 144, 19, 161, 19, 144, 19, 11 };
            int[] b = new int[] { 11 * 11, 121 * 121, 144 * 144, 19 * 19, 161 * 161, 19 * 19, 144 * 144, 19 * 19 };
            bool r = AreTheySame.comp(a, b); // True
            Assert.AreEqual(true, r);
        }

        [Test]
        public void Test2()
        {
            int[] a = new int[] { 120, 144, 19, 161, 19, 144, 19, 11 };
            int[] b = new int[] { 11 * 11, 121 * 121, 144 * 144, 19 * 19, 161 * 161, 19 * 19, 144 * 144, 19 * 19 };
            bool r = AreTheySame.comp(a, b); // True
            Assert.AreEqual(false, r);
        }

        [Test]
        public void Test3()
        {
            int[] a = new int[] { 5,4,3,2,1 };
            int[] b = new int[] { 1,4,9,16,25 };
            bool r = AreTheySame.comp(a, b); // True
            Assert.AreEqual(true, r);
        }

        [Test]
        public void Test4()
        {
            int[] a = null;
            int[] b = new int[] { 1, 4, 9, 16, 25 };
            bool r = AreTheySame.comp(a, b); // True
            Assert.AreEqual(false, r);
        }
    }
}
