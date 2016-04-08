using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RightTriagl_Project;

namespace RightTriagleTest
{
    [TestClass]
    public class RightTriagleTest
    {
        [TestMethod]
        public void AreaTest_a2b4()
        {
            double a = 2;
            double b = 4;
            double c = 4.4721;
                
            double expected = 4;
            double actual = RightTriagle.Area(a, b, c);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void AreaTest_ArgumentExceptionMinusA()
        {
            double a = -2;
            double b = 4;
            double c = 4.4721;

            RightTriagle.Area(a, b, c);
        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void AreaTest_ArgumentExceptionMinusB()
        {
            double a = 2;
            double b = -4;
            double c = 4.4721;

            RightTriagle.Area(a, b, c);
        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void AreaTest_ArgumentExceptionMinusC()
        {
            double a = 2;
            double b = 4;
            double c = -4.4721;

            RightTriagle.Area(a, b, c);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void AreaTest_ArgumentException0()
        {
            double a = 0;
            double b = 4;
            double c = 4.4721;

            RightTriagle.Area(a, b, c);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void AreaTest_ArgumentExceptionNotRight()
        {
            double a = 2;
            double b = 4;
            double c = 20;

            double expected = 4;
            double actual = RightTriagle.Area(a, b, c);
            Assert.AreEqual(expected, actual);
        }


    }
}
