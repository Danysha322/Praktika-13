using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp11
{
    public class InteractiveCourse : Course
    {
        public int ExerciseCount { get; set; }
        public bool HasAutoCheck { get; set; }

        public InteractiveCourse(string title, string description, string author, decimal price, int exercises, bool autoCheck)
            : base(title, description, author, price)
        {
            ExerciseCount = exercises;
            HasAutoCheck = autoCheck;
        }

        public override void StartLearning()
        {
            if (!IsPurchased)
            {
                Console.WriteLine("Сначала приобретите курс.");
                return;
            }
            Console.WriteLine($"Добро пожаловать в интерактивный курс! Вас ждет {ExerciseCount} упражнений.");
        }

        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine($"Тип: Интерактивный курс, Упражнения: {ExerciseCount}, Автопроверка: {HasAutoCheck}");
        }
    }
}
