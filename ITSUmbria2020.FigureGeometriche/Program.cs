using System;
using ItsUmbria2020.FigureGeometriche;

namespace ITSUmbria2020.FigureGeometriche
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Inserisci il tipo di figura: 1) Quadrato 2) Triangolo 3) Cerchio");
            int.TryParse(Console.ReadLine(), out int value);
            Console.WriteLine("Inserisci il nome");
            string Nome = Console.ReadLine();
            Console.WriteLine("Inserisci Base");
            int Base = int.Parse(Console.ReadLine());
            Console.WriteLine("Inserisci Altezza");
            int Altezza = int.Parse(Console.ReadLine());
            Console.WriteLine("Inserisci Raggio");
            int Raggio = int.Parse(Console.ReadLine());
            Figura figura = null;
            switch (value)
            {
                case 1:
                    Console.WriteLine
            }
        }
    }
}
