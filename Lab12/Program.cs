using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab12
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите значение радиуса");
            Circle.r= Convert.ToInt32(Console.ReadLine());
            Console.Write("Длина окружности= ");
            Console.WriteLine(Circle.length());
            Console.Write("Площадь окружности= ");
            Console.WriteLine(Circle.square());
            Console.WriteLine("Введите координаты точки Х");
            Circle.x= Convert.ToInt32(Console.ReadLine());
            Circle.y= Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(Circle.point());
            Console.ReadKey();
        }
        public static class Circle
        {
            public static double L;
            public static double S;
            public static double R;
            public static string X;
            public static double x;
            public static double y;
            public static int r;
            public static double length()
            {
                L = 2 * r * Math.PI;
               
                return L;
            }
            public static double square()
            {
                S = Math.PI * Math.Pow(r, 2);
                return S;
            }
            public static string point()
            {
                R = Math.Sqrt(Math.Pow(x, 2) + Math.Pow(y, 2));
                if (r == R)
                {
                    X = "Точка принадлежит кругу";
                }
                else 
                {
                    X = "Точка не принадлежит кругу";
                }
                return X;
            }
        }
    }
}
