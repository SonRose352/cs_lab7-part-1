using cs_lab7;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    internal class Cylinder:ICliable
    {
        //Поля
        protected Point2d A { get; set; }
        protected Point2d B { get; set; }
        protected double H { get; set; }

        //Конструкторы
        public Cylinder()
        {
            A = new Point2d(0, 0);
            B = new Point2d(5, 0);
            H = 5;
        }

        public Cylinder(Point2d a, Point2d b, double h)
        {
            A = a;
            B = b;
            H = h;
        }

        //Метод ввода
        public void input()
        {
            Console.WriteLine("Введите координаты центра основания цилиндра:");
            Console.Write("x = ");
            A.X = Convert.ToDouble(Console.ReadLine());
            Console.Write("y = ");
            A.Y = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите координаты точки на окружности основания цилиндра:");
            Console.Write("x = ");
            B.X = Convert.ToDouble(Console.ReadLine());
            Console.Write("y = ");
            B.Y = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите высоту цилиндра: ");
            H = Convert.ToDouble(Console.ReadLine());
        }

        //Метод вывода
        public void output()
        {
            Console.WriteLine($"Координаты центра основания цилиндра:\nx = {A.X}\ny = {A.Y}");
            Console.WriteLine($"Координаты точки на окружности основания цилиндра:\nx = {B.X}\ny = {B.Y}");
            Console.WriteLine($"Высота цилиндра: {H}");
        }

        //Метод, рассчитывающий площадь основания
        public virtual double baseSquare()
        {
            return Math.PI * Math.Pow(Point2d.distance(A, B), 2);
        }

        //Метод, рассчитывающий периметр основания
        public virtual double basePerimeter()
        {
            return 2 * Math.PI * Point2d.distance(A, B);
        }

        //Метод, рассчитывающий объём цилиндра
        public double volume()
        {
            return baseSquare() * H;
        }

        //Метод, рассчитывающий площадь боковой поверхности
        public double sideSurfaceSquare()
        {
            return basePerimeter() * H;
        }
    }
}