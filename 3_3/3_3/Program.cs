using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var p1 = new Point(0, 0);
            var p2 = new Point(3, 0);
            var p3 = new Point(0, 4);
            var t = new Triangle(p1, p2, p3);

            Console.WriteLine($"Треугольник ABC:\n  Сторона AB: {t.GetAB()}");   
            Console.WriteLine($"  Сторона BC: {t.GetBC()}");   
            Console.WriteLine($"  Сторона CA: {t.GetCA()}\n");

            Console.WriteLine($"Периметр: {t.GetPerimeter()}\n");
            Console.WriteLine($"Площаль: {t.GetSquare()}");
        }
    }

    public struct Point
    {
        public double X, Y;

        public Point(double x, double y)
        {
            this.X = x;
            this.Y = y;
        }
    }

    public struct Triangle
    {
        public Point A;
        public Point B;
        public Point C;

        public Triangle(Point a, Point b, Point c)
        {
            A = a;
            B = b;
            C = c;
        }

        public double GetLength(Point p1, Point p2) //вычесление длины между точечками
        {
            double dx = p2.X - p1.X;
            double dy = p2.Y - p1.Y;

            double dxSquared = dx * dx;
            double dySquared = dy * dy;

            double sumSquares = dxSquared + dySquared;

            return Math.Sqrt(sumSquares);
        }

        public double GetAB() => GetLength(A, B);
        public double GetBC() => GetLength(B, C);
        public double GetCA() => GetLength(C, A);

        public double GetPerimeter()
        {
            return (GetAB() + GetBC() + GetCA());
        }
        public double GetSquare()
        {
            double a = GetAB();
            double b = GetBC();
            double c = GetCA();

            double p = GetPerimeter() / 2;
            double underRoot = p * (p - a) * (p - b) * (p - c);

            if (underRoot < 0)
                underRoot = 0;
            return Math.Sqrt(underRoot);
        }
    }   
}
