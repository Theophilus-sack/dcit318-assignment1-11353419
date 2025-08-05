using System;

namespace ConsoleApp1
{
    public class TriangleIdentifier
    {
        public static void Run()
        {
            Console.WriteLine("Enter the lengths of the three sides:");

            double a = ReadSide("A");
            double b = ReadSide("B");
            double c = ReadSide("C");

            if (!IsValidTriangle(a, b, c))
            {
                Console.WriteLine("The sides do not form a valid triangle.");
                return;
            }

            string type = GetTriangleType(a, b, c);
            Console.WriteLine($"Triangle type: {type}");
        }

        private static double ReadSide(string label)
        {
            double value;
            Console.Write($"Side {label}: ");
            while (!double.TryParse(Console.ReadLine(), out value) || value <= 0)
            {
                Console.Write($"Invalid input. Enter a positive number for side {label}: ");
            }
            return value;
        }

        private static bool IsValidTriangle(double a, double b, double c)
        {
            return a + b > c && a + c > b && b + c > a;
        }

        private static string GetTriangleType(double a, double b, double c)
        {
            if (a == b && b == c) return "Equilateral";
            if (a == b || b == c || a == c) return "Isosceles";
            return "Scalene";
        }
    }
}
