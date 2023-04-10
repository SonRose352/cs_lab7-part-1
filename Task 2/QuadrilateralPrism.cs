using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    internal class QuadrilateralPrism:TriangularPrism
    {
        //Поле
        public Point2d D { get; set; }

        //Конструкторы
        public QuadrilateralPrism() : base()
        {
            D = new Point2d(5, 5);
        }

        public QuadrilateralPrism(Point2d a, Point2d b, Point2d c, Point2d d, double h):base(a, b, c, h)
        {
            D = d;
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
            Console.WriteLine("Введите координаты четвёртой вершины основания призмы:");
            Console.Write("x = ");
            D.X = Convert.ToDouble(Console.ReadLine());
            Console.Write("y = ");
            D.Y = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите высоту призмы: ");
            H = Convert.ToDouble(Console.ReadLine());
        }

        //Метод вывода
        public void output()
        {
            Console.WriteLine($"Координаты первой вершины основания призмы:\nx = {A.X}\ny = {A.Y}");
            Console.WriteLine($"Координаты второй вершины основания призмы:\nx = {B.X}\ny = {B.Y}");
            Console.WriteLine($"Координаты третьей вершины основания призмы:\nx = {C.X}\ny = {C.Y}");
            Console.WriteLine($"Координаты четвёртой вершины основания призмы:\nx = {D.X}\ny = {D.Y}");
            Console.WriteLine($"Высота призмы: {H}");
        }

        //Метод, рассчитывающий площадь основания призмы
        public override double baseSquare()
        {
            return base.baseSquare() + triangleSquare(Point2d.distance(A, C), Point2d.distance(C, D), Point2d.distance(A, D));
        }

        //Метод, рассчитывающий периметр основания
        public override double basePerimeter()
        {
            return Point2d.distance(A, B) + Point2d.distance(B, C) + Point2d.distance(C, D) + Point2d.distance(D, A);
        }

        //Метод, определяющий, является ли призма параллеллепипедом
        public bool isParall()
        {
            if (Point2d.distance(A, B) == Point2d.distance(C, D) && Point2d.distance(B, C) == Point2d.distance(A, D))
                return true;
            else 
                return false;
        }

        //Метод, определяющий, является ли призма прямоугольным параллелепипедом
        public bool isPryamParall()
        {
            if (isParall() && (int)Math.Pow(Point2d.distance(A, C), 2) == Math.Pow(Point2d.distance(A, B), 2) + Math.Pow(Point2d.distance(B, C), 2))
                return true;
            else
                return false;
        }

        //Метод, определяющий, является ли призма кубом
        public bool isCube()
        {
            if (isPryamParall() && Point2d.distance(A, B) == Point2d.distance(B, C) && Point2d.distance(A, B) == H)
                return true;
            else
                return false;
        }
    }
}
