using AreaCalculation;
using System;

namespace MindboxTest
{
    class Program
    {
        static void Main(string[] args)
        {
            try{
                Triangle tr = new Triangle(4, 3, 5);
                Console.WriteLine($"Площадь треугольника со сторонами:{tr.A}, {tr.B}, {tr.C} равна {tr.GetArea()}");
                if(tr.IsRectangular())
                    Console.WriteLine($"Треугольник является прямоугольным");
                else
                    Console.WriteLine($"Треугольник не является прямоугольным");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            try
            {
                Circle c = new Circle(5);
                Console.WriteLine($"Площадь окружности с радиусом {c.R} равна {c.GetArea()}");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine();
            }

            Figure tr2 = new Triangle(6, 7, 8);
            Console.WriteLine(tr2.GetArea());

            Figure c2 = new Circle(5);
            Console.WriteLine(c2.GetArea());

            Console.ReadKey();

        }
    }
}
