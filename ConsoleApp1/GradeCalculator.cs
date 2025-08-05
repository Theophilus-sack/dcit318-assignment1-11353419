using System;

namespace ConsoleApp1
{
    public class GradeCalculator
    {
        public static void Run()
        {
            Console.Write("Enter a numerical grade (0–100): ");
            string input = Console.ReadLine();
            if (int.TryParse(input, out int grade))
            {
                if (grade < 0 || grade > 100)
                {
                    Console.WriteLine("Grade must be between 0 and 100.");
                    return;
                }

                string letterGrade = GetLetterGrade(grade);
                Console.WriteLine($"The letter grade is: {letterGrade}");
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a number between 0 and 100.");
            }
        }

        private static string GetLetterGrade(int grade)
        {
            if (grade >= 90) return "A";
            if (grade >= 80) return "B";
            if (grade >= 70) return "C";
            if (grade >= 60) return "D";
            return "F";
        }
    }
}
