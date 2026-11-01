using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var red = new Color(255, 0, 0);
            var blue = new Color(0, 0, 255);
            var green = new Color(0, 255, 0);

            Console.WriteLine($"Red - {red.ToHex()}");
            Console.WriteLine($"Blue - {blue.ToHex()}");
            Console.WriteLine($"Green - {green.ToHex()}");
        }
    }

    public struct Color
    {
        public int R;
        public int G;
        public int B;

        public Color(int R, int G, int B)
        {
            this.R = R;
            this.G = G;
            this.B = B;
        }

        public string ToHex()
        { 
            return $"#{R:X2}{G:X2}{B:X2}";
        }
 
    }
}
