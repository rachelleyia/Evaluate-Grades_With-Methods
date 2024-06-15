using System;
using System.Diagnostics.SymbolStore;

namespace EvaluateGrades
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            // Get number of grades that the user wants to input
            Console.Write("Enter how many grades you want to input: ");
            int numberOfGrades = Convert.ToInt16(Console.ReadLine());//5

            double[] grades = GetGrades(numberOfGrades);

            Console.WriteLine("END OF USER INPUT");

            Console.WriteLine("PROCESSING GRADES....");

            double average = CalculateAverage(grades, numberOfGrades);

            Console.WriteLine("The average grade is " + average);

            EvaluateAverage(average);

            // Display all grades
            Console.WriteLine("Here are the grades given by your professor:");
            DisplayGrades(grades);
        }

        static double[] GetGrades(int numberOfGrades)
        {
            double[] grades = new double[numberOfGrades];

            // Get user input and put those in the array
            for (int counter = 0; counter < numberOfGrades; counter++)
            {
                Console.Write("Input grade: ");
                double grade = Convert.ToDouble(Console.ReadLine());

                if (grade >= 0 && grade <= 100)
                {
                    grades[counter] = grade;
                }
                else
                {
                    Console.WriteLine("Invalid Input. Please enter a grade between 0 and 100.");
                    counter--; // Decrement counter to repeat this iteration
                }
            }

            return grades;
        }

        static double CalculateAverage(double[] grades, int numberOfGrades)
        {
            double sum = 0;

            // Access the data in the array and get their sum
            for (int counter = 0; counter < numberOfGrades; counter++)
            {
                sum += grades[counter];
            }

            double average = sum / numberOfGrades;
            return average;
        }

        static void EvaluateAverage(double average)
        {
            if (average <= 50)
            {
                Console.WriteLine("FAILED");
            }
            else if (average > 50 && average <= 70)
            {
                Console.WriteLine("FAIR");
            }
            else if (average > 70 && average <= 80)
            {
                Console.WriteLine("GOOD");
            }
            else if (average > 80 && average <= 90)
            {
                Console.WriteLine("VERY GOOD");
            }
            else if (average > 90 && average <= 100)
            {
                Console.WriteLine("EXCELLENT");
            }
        }

        static void DisplayGrades(double[] grades)
        {
            for (int counter = 0; counter < grades.Length; counter++)
            {
                Console.Write(grades[counter] + " ");
            }
            Console.WriteLine(); // To move to the next line after printing all grades
        }
    }
}