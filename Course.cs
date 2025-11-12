using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp11
{
    public abstract class Course
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public string Author { get; set; }
        public decimal Price { get; set; }
        public bool IsPurchased { get; set; } = false;

        protected Course(string title, string description, string author, decimal price)
        {
            Title = title;
            Description = description;
            Author = author;
            Price = price;
        }

        public abstract void StartLearning();

        public virtual void DisplayInfo()
        {
            Console.WriteLine($"Курс: '{Title}'");
            Console.WriteLine($"Автор: {Author}");
            Console.WriteLine($"Описание: {Description}");
            Console.WriteLine($"Цена: {Price} руб.");
        }

        public void Purchase()
        {
            IsPurchased = true;
            Console.WriteLine($"Вы приобрели курс '{Title}'!");
        }
    }
}
