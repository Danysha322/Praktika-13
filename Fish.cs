using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp11
{
    public class Fish : Animal
    {
        public string ScaleType { get; set; }
        public double Depth { get; set; }

        public Fish(string species, int age, string habitat, string diet, string scaleType, double depth)
            : base(species, age, habitat, diet)
        {
            ScaleType = scaleType;
            Depth = depth;
        }

        public void Swim()
        {
            Console.WriteLine($"{Species} плавает на глубине {Depth} метров.");
        }

        public override void MakeSound()
        {
            Console.WriteLine($"{Species} не издает слышимых звуков.");
        }

        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine($"   Класс: Рыба, Тип чешуи: {ScaleType}, Глубина обитания: {Depth}м");
        }
    }
}
