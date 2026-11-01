using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var v1 = new Vector2D(2, 4);
            var v2 = new Vector2D(1, 2);
            var zero = new Vector2D(0, 0);//нулевой вектор
            
            Console.WriteLine($"v1 = {v1}, длина = {v1.Length()}");       //1
            Console.WriteLine($"v2 = {v2}, длина = {v2.Length()}\n");
            
            double dot = v1.Dot(v2);                                      //2
            Console.WriteLine($"Скалярное произведение v1·v2 = {dot}\n");  

            v1.Normalize();                                                //3
            Console.WriteLine($"Нормализация v1 = {v1}, длина v1 = {v1.Length()}");   


            zero.Normalize();
            Console.WriteLine($"Нормализация нулевого вектора = {zero}");

            Console.ReadKey();
        }
    }

    public struct Vector2D
    {
        public double x;
        public double y;

        public Vector2D(double x, double y)
        {
            this.x = x; this.y = y;
        }

        public double Length() => Math.Sqrt(x * x + y * y);
        
        public void Normalize()
        {
            if (Length() > 0)
            {
                x /= Length();
                y /= Length();
            }
            else
            {
                x = 0; y = 0;
            }

        }

        public double Dot(Vector2D other)
        {
            return x * other.x + y * other.y;
        }

        public override string ToString()
        {
            return $"({x:F2}, {y:F2})";
        }

    }
}
