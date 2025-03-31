using System;

namespace Week4Lesson13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                var number = GetNumber();

                if (number % 3 == 0 && number % 5 == 0)
                {
                    Console.WriteLine("FizzBuzz");
                    continue;
                }
                if (number % 3 == 0)
                {
                    Console.WriteLine("Fizz");
                    continue;
                }
                if (number % 5 == 0)
                { 
                    Console.WriteLine("Buzz");                 
                    continue;
                }

                Console.WriteLine(number);
            }           
        }

        public static int GetNumber()
        {
            while (true)
            {
                Console.WriteLine("Podaj liczbę (0 - koniec):");
                if (!int.TryParse(Console.ReadLine(), out int number))
                {
                    Console.WriteLine("Podałeś nieprawidłowe dane. Spróbuj ponownie.");
                    continue;
                }

                if (number == 0)
                {
                    Environment.Exit(0);
                }
                return number;
            }
        }
    }
}
