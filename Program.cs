using System;

namespace leet
{
    class Program
    {
        static void Main(string[] args)
        {
           string frase;

           Console.ForegroundColor = ConsoleColor.DarkGreen;
           Console.WriteLine("Digite uma frase para ser traduzida para a linguagem Leet Speak");
           Console.WriteLine("----------------------------");
           
           frase = Console.ReadLine();
         
           frase = frase.Replace("a", "4");
           frase = frase.Replace("A", "4");
           frase = frase.Replace("e", "3");
           frase = frase.Replace("E", "3");
           frase = frase.Replace("I", "1");
           frase = frase.Replace("i", "1");
           frase = frase.Replace("L", "1");
           frase = frase.Replace("l", "1");
           frase = frase.Replace("o", "0");
           frase = frase.Replace("O", "0");
           frase = frase.Replace("T", "7");
           frase = frase.Replace("t", "7");
           frase = frase.Replace("S", "5");
           frase = frase.Replace("s", "5");
           
           Console.WriteLine($"{frase}");
           
           

           
        }
    }
}
