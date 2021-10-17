using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ввести строку");
            string text = Console.ReadLine();
            Console.WriteLine("Ввести ключ");
            string key = Console.ReadLine();
            string intext = Caesar.Encrypt(text, key);
            Console.WriteLine(intext);
            string ditext = Caesar.Dencrypt(intext, key);
            Console.WriteLine(ditext);
            Console.ReadKey();
        }
    }
}
