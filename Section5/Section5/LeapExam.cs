using System;

public class ExamLeapYear
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Please enter a year to validate if it's a leap year or not:");
        
        // Read user input and convert to an integer
        if (int.TryParse(Console.ReadLine(), out int year))
        {
            if (IsLeapYear(year))
            {
                Console.WriteLine($"{year} is a leap year.");
            }
            else
            {
                Console.WriteLine($"{year} is not a leap year.");
            }
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a valid year.");
        }
    }

    public static bool IsLeapYear(int year)
    {
        // A year is a leap year if:
        // 1. It is divisible by 4.
        // 2. It is not divisible by 100 unless it is also divisible by 400.
        return (year % 4 == 0 && (year % 100 != 0 || year % 400 == 0));
    }
}
