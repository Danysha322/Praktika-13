using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp11
{
    public class TextCourse : Course
    {
        public int ChapterCount { get; set; }
        public int TotalPages { get; set; }

        public TextCourse(string title, string description, string author, decimal price, int chapters, int pages)
            : base(title, description, author, price)
        {
            ChapterCount = chapters;
            TotalPages = pages;
        }

        public override void StartLearning()
        {
            if (!IsPurchased)
            {
                Console.WriteLine("Сначала приобретите курс.");
                return;
            }
            Console.WriteLine($"Открыт текстовый курс. Приготовьтесь прочитать {ChapterCount} глав.");
        }

        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine($"   Тип: Текстовый курс, Главы: {ChapterCount}, Страниц: ~{TotalPages}");
        }
    }
}
