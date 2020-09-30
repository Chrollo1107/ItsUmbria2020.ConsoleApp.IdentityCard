using System;
namespace ItsUmbria2020.CarFactory
{
    class Program
    {

        static void Main(string[] args)
        {
            ICarFactory carFactory = new CarFactory();
            Console.WriteLine("Inserisci la targa del veicolo: ");
            string Targa = Console.ReadLine();
            Console.WriteLine("Inserisci il nome del proprietario: ");
            string Nome = Console.ReadLine();
            Console.WriteLine("Che modello di macchina vuoi inserire? 1) Suv 2) Coupe");
            string CarType = Console.ReadLine();
            Car car = new CarFactory().GetCar(CarType);


            switch (CarType)
            {
                case "1":
                    Console.WriteLine("Inserire la cilindrata del Suv: ");
                    string Cilindrata = Console.ReadLine();
                    if (car is ICilindrata)
                    {
                        Console.WriteLine("Inserisci la cilindrata");
                        int cilindrata = int.Parse(Console.ReadLine());
                        ((ICilindrata)car).Cilindrata = cilindrata;
                    }
                    Console.WriteLine($"Abbiamo immatricolato la macchina {CarType} {Targa} di {Nome} con cilindrata {Cilindrata}");
                    break;


                case "2":
                    Console.WriteLine("Inserire il colore del Coupe: ");
                    string Colore = Console.ReadLine();
                    if (car is IColor)
                    {
                        Console.WriteLine("Di che colore è la macchina?");
                        string colore = Console.ReadLine();
                        ((IColor)car).Color = colore;
                    }
                    Console.WriteLine($"Abbiamo immatricolato la macchina {CarType} {Targa} di {Nome} con colore {Colore}");
                    break;
            }
        }
    }



}