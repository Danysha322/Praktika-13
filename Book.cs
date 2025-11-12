using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp11
{
    public class Book : LibraryItem
    {
        public int PageCount { get; set; }
        public string ISBN { get; set; }

        public Book(string title, string author, int year, int pageCount, string isbn)
            : base(title, author, year)
        {
            PageCount = pageCount;
            ISBN = isbn;
        }

        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine($"   Тип: Книга, Страниц: {PageCount}, ISBN: {ISBN}");
        }
    }
}
