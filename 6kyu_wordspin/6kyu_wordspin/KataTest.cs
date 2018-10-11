﻿using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6kyu_wordspin
{
    [TestFixture]
    class KataTest
    {
        [Test]
        public static void Test1()
        {
            Assert.AreEqual("emocleW", Kata.SpinWords("Welcome"));
        }

        [Test]
        public static void Test2()
        {
            Assert.AreEqual("Hey wollef sroirraw", Kata.SpinWords("Hey fellow warriors"));
        }

        [Test]
        public static void Test3()
        {
            Assert.AreEqual("This is a test", Kata.SpinWords("This is a test"));
        }

        [Test]
        public static void Test4()
        {
            Assert.AreEqual("This is rehtona test", Kata.SpinWords("This is another test"));
        }

        [Test]
        public static void Test5()
        {
            Assert.AreEqual("You are tsomla to the last test", Kata.SpinWords("You are almost to the last test"));
        }

        [Test]
        public static void Test6()
        {
            Assert.AreEqual("Just gniddik ereht is llits one more", Kata.SpinWords("Just kidding there is still one more"));
        }

        [Test]
        public static void Test7()
        {
            Assert.AreEqual("Hi I'm Jake I like to sing", Kata.SpinWords("Hi I'm Jake I like to sing"));
        }

        [Test]
        public static void Test8()
        {
            Assert.AreEqual("", Kata.SpinWords(""));
        }
    }
}
