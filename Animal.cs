using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp11
{
    public abstract class Animal
    {
        public string Species { get; set; }
        public int Age { get; set; }
        protected string Habitat { get; set; }
        protected string Diet { get; set; }

        protected Animal(string species, int age, string habitat, string diet)
        {
            Species = species;
            Age = age;
            Habitat = habitat;
            Diet = diet;
        }

        public virtual void Eat()
        {
            Console.WriteLine($"{Species} ест {Diet}.");
        }

        public virtual void Sleep()
        {
            Console.WriteLine($"{Species} спит в своем вольере.");
        }

        public abstract void MakeSound();

        public virtual void DisplayInfo()
        {
            Console.WriteLine($"Вид: {Species}, Возраст: {Age} лет, Среда обитания: {Habitat}, Рацион: {Diet}");
        }
    }
}
