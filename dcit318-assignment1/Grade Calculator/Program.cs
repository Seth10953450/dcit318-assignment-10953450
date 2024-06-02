﻿using System;

namespace GradeCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a numerical grade between 0 and 100: ");
            string input = Console.ReadLine() ?? string.Empty; // Handle potential null value
            if (int.TryParse(input, out int grade) && grade >= 0 && grade <= 100)
            {
                if (grade >= 90)
                {
                    Console.WriteLine("Grade: A");
                }
                else if (grade >= 80)
                {
                    Console.WriteLine("Grade: B");
                }
                else if (grade >= 70)
                {
                    Console.WriteLine("Grade: C");
                }
                else if (grade >= 60)
                {
                    Console.WriteLine("Grade: D");
                }
                else
                {
                    Console.WriteLine("Grade: F");
                }
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a numerical grade between 0 and 100.");
            }
        }
    }
}
