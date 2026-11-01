using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace _2_1
{
    internal class Program
    {
        // если честно, то я вообще не поняла комплексные числа... и как они вообще работают :( поэтмоу слегка ии-шно
        static void Main(string[] args)
        {
            var z1 = new ComplexNumber(3, 4);   // 3 + 4i
            var z2 = new ComplexNumber(1, -2);  // 1 - 2i

            var sum = ComplexNumber.Add(z1, z2);
            var diff = ComplexNumber.Subtract(z1, z2);
            var prod = ComplexNumber.Multiply(z1, z2);

            Console.WriteLine($"z1 = {z1}");
            Console.WriteLine($"z2 = {z2}");
            Console.WriteLine($"Сумма: {sum}");
            Console.WriteLine($"Разность: {diff}");
            Console.WriteLine($"Умножение: {prod}");
        }
    }

    public struct ComplexNumber
    {
        public double Real;
        public double Imag;

        public ComplexNumber(double Real, double Imag)
        {
            this.Real = Real;
            this.Imag = Imag;
        }

        public static ComplexNumber Add(ComplexNumber a, ComplexNumber b)
        {
            return new ComplexNumber(a.Real + b.Real, a.Imag + b.Imag);
        }

        public static ComplexNumber Subtract(ComplexNumber a, ComplexNumber b)
        {
            return new ComplexNumber(a.Real - b.Real, a.Imag - b.Imag);
        }

        public static ComplexNumber Multiply(ComplexNumber a, ComplexNumber b)
        {
            double realPart = a.Real * b.Real - a.Imag * b.Imag;
            double imagPart = a.Real * b.Imag + a.Imag * b.Real;
            return new ComplexNumber(realPart, imagPart);
        }

        public override string ToString()
        {
            if (Imag == 0)
                return Real.ToString();

            string sign = Imag >= 0 ? "+" : "-";
            double absImag = Math.Abs(Imag);
            string imagString = absImag == 1 ? "i" : absImag + "i";

            return $"{Real} {sign} {imagString}";
        }
    }
}

