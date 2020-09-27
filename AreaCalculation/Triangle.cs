using System;
using System.Collections.Generic;
using System.Text;

namespace AreaCalculation
{
    public class Triangle : Figure
    {
        public int A { get; set; }
        public int B { get; set; } 
        public int C { get; set; } 

        public Triangle(int a, int b, int c)
        {
            if (a +b >c && a +c> b && b + c > a && a>0 && b>0 && c>0)
            {
                A = a;
                B = b;
                C = c;
            }
            else
            {
               throw  new Exception($"Треугольника с сторонами {a}, {b}, {c} не существует");
            }
        }


        public override double GetArea()
        {
            double p = (A + B + C) / 2.0;
            return Math.Sqrt(p * (p - A) * (p - B) * (p - C));
        }


        public bool IsRectangular()
        {
            if (B * B + C * C == A * A || A * A + B * B == C * C || A * A + C * C == B * B)
                return true;
            else
                return false;
        }

    }
}
