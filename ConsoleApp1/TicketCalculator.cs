using System;

namespace ConsoleApp1
{
    public class TicketCalculator
    {
        public static void Run()
        {
            Console.Write("Enter your age: ");
            string input = Console.ReadLine();
            if (int.TryParse(input, out int age))
            {
                decimal price = CalculatePrice(age);
                Console.WriteLine($"Ticket price: GHC{price}");
            }
            else
            {
                Console.WriteLine("Invalid age input.");
            }
        }

        private static decimal CalculatePrice(int age)
        {
            return (age <= 12 || age >= 65) ? 7.00m : 10.00m;
        }
    }
}
