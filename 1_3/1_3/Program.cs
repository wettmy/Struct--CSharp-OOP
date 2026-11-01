using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var book = new Book("Под стеклянным колпаком", "Сильвия Плат", 1963);
            Console.WriteLine(book);
        }

        public struct Book
        {
            public string Title;
            public string Author;
            public int Year;

            public Book (string title, string author, int year)
            {
                this.Title = title;
                this.Author = author;   
                this.Year = year;

            }

            public override string ToString()
            {
                return $"{Title} - {Author} ({Year})";
            }
               
        }
    }
}
