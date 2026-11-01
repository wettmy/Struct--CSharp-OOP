using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var p1 = new Point3D(3, 0, 2);
            var p2 = new Point3D(5, 2, 6);

            double dist = p1.GetLength(p2);

            Console.WriteLine($"Точка 1: {p1}");
            Console.WriteLine($"Точка 2: {p2}");
            Console.WriteLine($"Расстояние между ними: {dist}");
        }
    }

    public struct Point3D
    {
        public double X, Y, Z;

        public Point3D(double x, double y, double z)
        {
            this.X = x; this.Y = y; this.Z = z;
        }

        public double GetLength(Point3D other)
        {
            double dx = other.X - X;
            double dy = other.Y - Y;
            double dz = other.Z - Z;

            return Math.Sqrt(dx * dx + dy * dy + dz * dz);
        }

        // Бонус: чтобы удобно выводить точку на экран
        public override string ToString() => $"({X}, {Y}, {Z})";
    }
    //чтото по сравнению с прошлым это выглядит подозрительно. 
    //и из 3 уровня задания выглядят проще в математическом плане, нежели из 2-ого...   
}
