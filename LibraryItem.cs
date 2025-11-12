using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp11
{
    public class LibraryItem
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public int Year { get; set; }
        public bool IsAvailable { get; set; } = true;

        public LibraryItem(string title, string author, int year)
        {
            Title = title;
            Author = author;
            Year = year;
        }

        public virtual void DisplayInfo()
        {
            string status = IsAvailable ? "Доступен" : "Выдан";
            Console.WriteLine($"'{Title}' - {Author} ({Year}) - {status}");
        }
    }
}
