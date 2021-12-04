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
            Console.WriteLine("Длина окружности= {0}", Circle.L);
            Console.WriteLine("Площадь круга= {0}", Circle.S);
            Console.WriteLine(Circle.X);
            Console.ReadKey();
        }
        public static class Circle
        {
            public static double L;
            public static double S;
            public static double l;
            public static double s;
            public static double R;
            public static string X;
            public static double x;
            public static double y;
            public static int r;
            static double length()
            {
                l = 2 * r * Math.PI;
                L = l;
                return L;
            }
            static double square()
            {
                S = Math.PI * Math.Pow(r, 2);
                S = s;
                return S;
            }
            static string point()
            {
                R = Math.Sqrt(Math.Pow(x, 2) + Math.Pow(y, 2));
                if (r == R)
                {
                    X = "Точка принадлежит кругу";
                }
                return X;
            }
        }
    }
}
