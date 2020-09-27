using Microsoft.VisualStudio.TestTools.UnitTesting;
using AreaCalculation;
using System;
using System.Collections.Generic;
using System.Text;

namespace AreaCalculation.Tests
{
    [TestClass()]
    public class FigureTests
    {
        [TestMethod()]
        public void GetAreaTest()
        {
            Figure tr = new Triangle(5, 4, 3);
            Figure c = new Circle(1);

            double actualTr = tr.GetArea();
            int expendTr = 6;
            double actualC = c.GetArea();
            double expendC = 3.14159265;

            Assert.IsTrue(Math.Abs(actualTr -expendTr ) < 1e-6);
            Assert.IsTrue(Math.Abs(actualC - expendC) < 1e-6);
        }
    }
}