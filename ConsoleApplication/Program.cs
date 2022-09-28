using System;

namespace ConsoleApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введіть число ");
            int number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Ви ввели число {number}");
        }
    }
}

