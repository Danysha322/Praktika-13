using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp11
{
    public class DVD : LibraryItem
    {
        public int DurationMinutes { get; set; }
        public string Rating { get; set; }

        public DVD(string title, string director, int year, int duration, string rating)
            : base(title, director, year)
        {
            DurationMinutes = duration;
            Rating = rating;
        }

        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine($"   Тип: DVD, Продолжительность: {DurationMinutes} мин., Рейтинг: {Rating}");
        }
    }
}
