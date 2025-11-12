using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp11
{
    public class Reptile : Animal
    {
        public string SkinType { get; set; }
        public double PreferredTemperature { get; set; }

        public Reptile(string species, int age, string habitat, string diet, string skinType, double temp)
            : base(species, age, habitat, diet)
        {
            SkinType = skinType;
            PreferredTemperature = temp;
        }

        public void ShedSkin()
        {
            Console.WriteLine($"{Species} сбрасывает свою кожу ({SkinType}).");
        }

        public override void MakeSound()
        {
            Console.WriteLine($"{Species} шипит или издает тихий звук.");
        }

        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine($"   Класс: Рептилия, Тип кожи: {SkinType}, Предпочитаемая температура: {PreferredTemperature}°C");
        }
    }
}
