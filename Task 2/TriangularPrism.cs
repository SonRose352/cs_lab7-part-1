using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    internal class TriangularPrism : Cylinder
    {
        //Поле
        protected Point2d C { get; set; }

        //Конструкторы
        public TriangularPrism() : base()
        {
            C = new Point2d(0, 5);
        }

        public TriangularPrism(Point2d a, Point2d b, Point2d c, double h):base(a, b, h)
        {
            C = c;
        }

        //Метод ввода
        public void input()
        {
            Console.WriteLine("Введите координаты первой вершины основания призмы:");
            Console.Write("x = ");
            A.X = Convert.ToDouble(Console.ReadLine());
            Console.Write("y = ");
            A.Y = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите координаты второй вершины основания призмы:");
            Console.Write("x = ");
            B.X = Convert.ToDouble(Console.ReadLine());
            Console.Write("y = ");
            B.Y = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите координаты третьей вершины основания призмы:");
            Console.Write("x = ");
            C.X = Convert.ToDouble(Console.ReadLine());
            Console.Write("y = ");
            C.Y = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите высоту призмы: ");
            H = Convert.ToDouble(Console.ReadLine());
        }

        //Метод вывода
        public void output()
        {
            Console.WriteLine($"Координаты первой вершины основания призмы:\nx = {A.X}\ny = {A.Y}");
            Console.WriteLine($"Координаты второй вершины основания призмы:\nx = {B.X}\ny = {B.Y}");
            Console.WriteLine($"Координаты третьей вершины основания призмы:\nx = {C.X}\ny = {C.Y}");
            Console.WriteLine($"Высота призмы: {H}");
        }

        //Метод, рассчитывающий площадь треугольника по сторонам
        protected static double triangleSquare(double a, double b, double c)
        {
            double p = (a + b + c) / 2;
            return Math.Sqrt(p * (p - a) * (p - b) * (p - c));
        }

        //Метод, рассчитывающий площадь основания призмы
        public override double baseSquare()
        {
            return triangleSquare(Point2d.distance(A, B), Point2d.distance(B, C), Point2d.distance(A, C));
        }

        //Метод, рассчитывающий периметр основания призмы

        public override double basePerimeter()
        {
            return Point2d.distance(A, B) + Point2d.distance(B, C) + Point2d.distance(A, C);
        }
    }
}
