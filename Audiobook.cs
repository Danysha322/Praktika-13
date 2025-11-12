using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp11
{
    public class Audiobook : LibraryItem
    {
        public int DurationMinutes { get; set; }
        public string Narrator { get; set; }

        public Audiobook(string title, string author, int year, int duration, string narrator)
            : base(title, author, year)
        {
            DurationMinutes = duration;
            Narrator = narrator;
        }

        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine($"   Тип: Аудиокнига, Продолжительность: {DurationMinutes} мин., Диктор: {Narrator}");
        }
    }
}
