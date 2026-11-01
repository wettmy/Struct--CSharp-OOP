using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var rect = new Rectangle(6, 2);
            Console.WriteLine(rect);
            Console.WriteLine(rect.ToString());
        }
    }

    public struct Rectangle
    {
        public double wedth;
        public double height;

        public Rectangle (double wedth, double height)
        {
            this.wedth = wedth;
            this.height = height;
        }

        public double Square() => wedth * height;
        public double Perimether() => 2 * (wedth + height);

        public override string ToString()
        {
            return $"Rectangle: {wedth}*{height}. square = {Square()}, perimether = {Perimether()}";
        }
    }
}
