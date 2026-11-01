using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var m1 = new Money(15, 50);
            var m2 = new Money(17, 67);

            var sum = m1.Add(m2);
            var diff = m1.Sub(m2);

            Console.WriteLine($"m1 = {m1}");
            Console.WriteLine($"m2 = {m2} \n");
            Console.WriteLine($"Сумма: {sum} \n");          // Будет: "121 руб. 25 коп."
            Console.WriteLine($"Разность: {diff}  \n");       // Будет: "79 руб. 75 коп."

            int result = m1.Compare(m2);
            if (result > 0)
                Console.WriteLine("m1 больше m2");
            else if (result < 0)
                Console.WriteLine("m1 меньше m2");
            else
                Console.WriteLine("Суммы равны");

            Console.ReadKey();
        }
    }

    public struct Money
    {
        public int Rubles;
        public int Kopecks;

        public Money(int Rubles, int Kopecks)
        {
            this.Rubles = Rubles;
            this.Kopecks = Kopecks;
        }

        public Money Add(Money other) 
        {


            int newRubles = Rubles + other.Rubles;
            int newKopecks = Kopecks + other.Kopecks;

            if (newKopecks >= 100)
            {
                newRubles += newKopecks / 100;      //полных рублей
                newKopecks = newKopecks % 100;     //осталось копеек
            }

            return new Money(newRubles, newKopecks);
        }
        public Money Sub(Money other)
        {
            int newRubles = Rubles - other.Rubles;
            int newKopecks = Kopecks - other.Kopecks;

            if (newKopecks < 0) //чтобы не было минусов
            {
                newKopecks += 100;      // добавляем 100 копеек
                newRubles -= 1;        // забираем 1 рубль 
            }

            return new Money(newRubles, newKopecks);
        }

        public int Compare(Money other)
        {
            int thisInKopecks = Rubles * 100 + Kopecks;
            int otherInKopecks = other.Rubles * 100 + other.Kopecks;

            if (thisInKopecks > otherInKopecks)
                return 1;
            else if (thisInKopecks < otherInKopecks)
                return -1;
            else
                return 0;
        }

        public override string ToString()
        {
            return $"{Rubles} руб. {Kopecks} коп.";
        }
    }
}
