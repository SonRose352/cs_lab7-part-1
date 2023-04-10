using cs_lab7;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    internal class Point2d:ICliable
    {
        //Поля
        public double X { get; set; }
        public double Y { get; set; }

        //Конструкторы
        public Point2d()
        {
            X = 0;
            Y = 0;
        }

        public Point2d(double x, double y)
        {
            X = x;
            Y = y;
        }

        //Метод ввода
        public void input()
        {
            Console.Write("Введите координату 'x': ");
            X = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите координату 'y': ");
            Y = Convert.ToDouble(Console.ReadLine());
        }

        //Метод вывода
        public void output()
        {
            Console.WriteLine($"x = {X}\ny = {Y}");
        }

        //Метод ToString
        public override string ToString()
        {
            return X + " " + Y;
        }

        //Метод расчёта расстояния между двумя точками
        public static double distance(Point2d a, Point2d b)
        {
            return Math.Sqrt(Math.Pow(a.X - b.X, 2) + Math.Pow(a.Y - b.Y, 2));
        }
    }
}
