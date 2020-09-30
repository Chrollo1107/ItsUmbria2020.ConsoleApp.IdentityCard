using System;

namespace ITSUmbria2020.Noe
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Tipo di animale: 1)Erbivoro, 2)Carnivoro,");
            string AnimalType = Console.ReadLine();
            Animal animal = new AnimalFactory().GetAnimal(AnimalType);
            Console.WriteLine("Animale :");
            string genere = Console.ReadLine();
            switch (AnimalType)
                case "1":




        }
    }
    
}
