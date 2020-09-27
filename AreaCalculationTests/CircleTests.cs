using Microsoft.VisualStudio.TestTools.UnitTesting;
using AreaCalculation;
using System;
using System.Collections.Generic;
using System.Text;

namespace AreaCalculation.Tests
{
    [TestClass()]
    public class CircleTests
    {
        [TestMethod()]
        public void GetAreaTest()
        {
            Circle c = new Circle(1);
            double actual = c.GetArea();
            Assert.IsTrue(3.14159265 - actual < 1e-6);
        }

        [TestMethod()]
        public void CircleTest()
        {
            Circle c = new Circle(5);
            Assert.AreEqual(5, c.R);
            Assert.ThrowsException<Exception>(() => new Circle(-1));
        }

       
    }
}