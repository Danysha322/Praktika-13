using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp11
{
    public class Mammal : Animal
    {
        public string FurType { get; set; }
        public int GestationPeriod { get; set; }

        public Mammal(string species, int age, string habitat, string diet, string furType, int gestation)
            : base(species, age, habitat, diet)
        {
            FurType = furType;
            GestationPeriod = gestation;
        }

        public void GiveBirth()
        {
            Console.WriteLine($"{Species} вынашивает детеныша {GestationPeriod} дней.");
        }

        public override void MakeSound()
        {
            Console.WriteLine($"{Species} издает характерный для млекопитающих звук.");
        }

        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine($"   Класс: Млекопитающее, Тип меха: {FurType}, Беременность: {GestationPeriod} дн.");
        }
    }
}
