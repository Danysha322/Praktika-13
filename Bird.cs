using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp11
{
    public class Bird : Animal
    {
        public double Wingspan { get; set; }
        public string NestingType { get; set; }

        public Bird(string species, int age, string habitat, string diet, double wingspan, string nesting)
            : base(species, age, habitat, diet)
        {
            Wingspan = wingspan;
            NestingType = nesting;
        }

        public void Fly()
        {
            Console.WriteLine($"{Species} парит в небе с размахом крыльев {Wingspan}м.");
        }

        public override void MakeSound()
        {
            Console.WriteLine($"{Species} поет или издает звуки.");
        }

        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine($"   Класс: Птица, Размах крыльев: {Wingspan}м, Гнездование: {NestingType}");
        }
    }
}
