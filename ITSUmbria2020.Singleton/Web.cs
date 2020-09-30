using System;
using System.Collections.Generic;
using System.Text;

namespace ITSUmbria2020.Singleton
{
    class Web
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Inserisci la frase che andrà nel div");
            string input = Console.ReadLine();
            Console.BackgroundColor = Styling.Instance().BackgroundColor;
            Console.ForegroundColor = Styling.Instance().ConsoleColor;
            Console.WriteLine($"<div>{input}</div>");
        }

    }
}
