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

                var fizzbuzz = new FizzBuzz();                

                Console.WriteLine(fizzbuzz.ReturnString(number));
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
