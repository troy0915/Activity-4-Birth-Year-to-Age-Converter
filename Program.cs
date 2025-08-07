using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Activity_4_Birth_Year_to_Age_Converter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> birthYears = new List<string>();
            const int currentYear = 2023; // You can also use DateTime.Now.Year for the current year
            Console.WriteLine("Please enter 5 birth years:");

            for (int i = 0; i < 5; i++)
            {
                string input;
                int birthYear;

                while (true)
                {
                    Console.Write($"Birth Year {i + 1}: ");
                    input = Console.ReadLine();
                    if (int.TryParse(input, out birthYear))
                    {
                        birthYears.Add(input);
                        break; // Exit the loop if input is valid
                    }
                    else
                    {
                        Console.WriteLine("Invalid input. Please enter a numeric year.");
                    }
                }
            }
            Console.WriteLine("\nAge classification:");
            foreach (var year in birthYears)
            {
                int birthYear = Convert.ToInt32(year);
                int age = currentYear - birthYear;

                string classification;

                if (age < 18)
                {
                    classification = "Minor";
                }
                else if (age >= 18 && age < 65)
                {
                    classification = "Adult";
                }
                else
                {
                    classification = "Senior";
                }
                Console.WriteLine($"Birth Year: {birthYear}, Age: {age}, Classification: {classification}");
            }
        }
    }
}





