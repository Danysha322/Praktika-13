using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp11
{
    public class VideoCourse : Course
    {
        public int VideoCount { get; set; }
        public int TotalDurationMinutes { get; set; }

        public VideoCourse(string title, string description, string author, decimal price, int videoCount, int duration)
            : base(title, description, author, price)
        {
            VideoCount = videoCount;
            TotalDurationMinutes = duration;
        }

        public override void StartLearning()
        {
            if (!IsPurchased)
            {
                Console.WriteLine("Сначала приобретите курс.");
                return;
            }
            Console.WriteLine($"Запуск видеоплеера... Наслаждайтесь {VideoCount} видеоуроками.");
        }

        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine($"   Тип: Видеокурс, Кол-во видео: {VideoCount}, Длительность: {TotalDurationMinutes} мин.");
        }
    }
}
