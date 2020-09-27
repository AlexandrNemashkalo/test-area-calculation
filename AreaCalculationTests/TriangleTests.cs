using Microsoft.VisualStudio.TestTools.UnitTesting;
using AreaCalculation;
using System;
using System.Collections.Generic;
using System.Text;

namespace AreaCalculation.Tests
{
    [TestClass()]
    public class TriangleTests
    {
        [TestMethod()]
        public void GetAreaTest()
        {
            Triangle tr = new Triangle(5, 4, 3);
            double actual = tr.GetArea();
            Assert.IsTrue(Math.Abs(6 - actual) < 1e-6);
        }

        [TestMethod()]
        public void IsRectangularTest()
        {
            Triangle tr1 = new Triangle(5, 4, 3);
            Assert.IsTrue(tr1.IsRectangular());

            Triangle tr2 = new Triangle(6, 7, 8);
            Assert.IsFalse(tr2.IsRectangular());
        }

        [TestMethod()]
        public void TriangleTest()
        {
            Triangle tr = new Triangle(5,4,3);
            Assert.IsTrue(tr.A == 5 && tr.B ==4 && tr.C == 3);
            Assert.ThrowsException<Exception>(() =>  new Triangle(100, 4, 3));
        }
    }
}