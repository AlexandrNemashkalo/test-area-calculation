using System;
using System.Collections.Generic;
using System.Text;

namespace AreaCalculation
{
    public class Circle : Figure
    {
        public int R { get; set; }

        public Circle(int r)
        {
            if (r>0)
                R = r;      
            else
                throw new Exception("Радиус не может быть отрицательным");         
        }

        public override double GetArea()
        {
            return Math.PI * R * R;
        }
    }
}
