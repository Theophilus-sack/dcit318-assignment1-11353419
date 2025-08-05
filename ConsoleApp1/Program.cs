using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Console.WriteLine("GRADE CALCULATOR");
            GradeCalculator.Run();

            Console.WriteLine("\nPress Enter to exit...");
            Console.ReadLine();
        }
    }
}
