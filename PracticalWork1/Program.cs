using System;

namespace PracticalWork1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Как Вас зовут?");
            string name = Console.ReadLine();
            Console.WriteLine($"Привет, {name}, сегодня "+DateTime.Now);
            Console.ReadKey();
        }
    }
}
