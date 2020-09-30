using System;
using System.Collections.Generic;
using System.Text;

namespace ITSUmbria2020.Noe
{
    class AnimalFactory : IAnimalFactory
    {
        public Animal GetAnimal(string AnimalType)
        {
            switch (AnimalType)
            {
                case "1":
                    return new Erbivoro();
                default:
                case "2":
                    return new Carnivoro();
            }
        }
    }
    abstract class Animal
    {
        public string Name => this.GetType().Name;
    }
    class Erbivoro : Animal
    {

    }
    class Carnivoro : Animal
    {
      
    }
}
