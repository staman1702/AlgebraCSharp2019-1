using Microsoft.VisualStudio.TestTools.UnitTesting;
using _8_2_1_Static_ZADACA;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_2_1_Static_ZADACA.Tests
{
    [TestClass()]
    public class StaticTests
    {
        [TestMethod()]
        public void ZbrojTest()
        {
            Assert.AreEqual(6, Static.Zbroj(3.4,2.6));
        }

        [TestMethod()]
        public void KubTest()
        {
            Assert.AreEqual(27, Static.Kub(3));
        }

        [TestMethod()]
        public void UdaljnostTest()
        {
            Assert.AreEqual(8, Static.Udaljenost(0,1,8,1));
           
        }
        [TestMethod()]
        public void FahrenheitTest()
        {
            Assert.AreEqual(50, Static.Fahrenheit(10));
        }

    }
}