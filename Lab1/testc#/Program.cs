using System;
using static System.Console;
using static System.Math;

class Program
{
    static void Main()
    {
        bool keepRunning = true;

        while (keepRunning)
        {
            WriteLine("Select the task number (1-6) or 0 to exit:");
            Write("Your choice: ");
            string input = ReadLine();

            switch (input)
            {
                case "1":
                    Task1();
                    break;
                case "2":
                    Task2();
                    break;
                case "3":
                    Task3();
                    break;
                case "4":
                    Task4();
                    break;
                case "5":
                    Task5();
                    break;
                case "6":
                    Task6();
                    break;
                case "0":
                    keepRunning = false;
                    WriteLine("Exiting the program...");
                    break;
                default:
                    WriteLine("Error: Invalid input. Please enter a number between 0 and 6..");
                    break;
            }
        }
    }

    static void Task1()
    {
        WriteLine("\n--- Task 1 is being performed ---");
        Write("Input perimeter (p): ");
        double p = Convert.ToDouble(ReadLine());
        WriteLine($"Area (S): {Sqrt(3) / 36 * p * p:F4}");
    }

    static void Task2()
    {
        WriteLine("\n--- Task 2 is being performed ---");
        Write("Enter an integer: ");
        if (int.TryParse(ReadLine(), out int number))
        {
            if (number % 2 == 0)
            {
                WriteLine($"Number {number} is even.");
            }
            else
            {
                WriteLine($"Number {number} is odd.");
            }
        }
        else
        {
            WriteLine("Error: Please enter a valid integer.");
        }
    }

    static void Task3()
    {
        WriteLine("\n--- Task 3 is being performed ---");
        Write("Enter the x-coordinate: ");
        double x = Convert.ToDouble(ReadLine());

        Write("Enter the y-coordinate: ");
        double y = Convert.ToDouble(ReadLine());

        double distanceSquared = x * x + y * y;
        double radiusSquared = 81;

        if (distanceSquared < radiusSquared && x > 0)
        {
            WriteLine("Yes");
        }
        else if ((distanceSquared == radiusSquared && x >= 0) || (x == 0 && y >= -9 && y <= 9))
        {
            WriteLine("On the edge");
        }
        else
        {
            WriteLine("No");
        }
    }

    static void Task4()
    {
        WriteLine("\n--- Task 4 is being performed ---");
        Write("Enter the ordinal number of the day of the month: ");

        if (int.TryParse(ReadLine(), out int currentDay))
        {
            var now = DateTime.Now;
            int totalDaysInMonth = DateTime.DaysInMonth(now.Year, now.Month);

            if (currentDay > 0 && currentDay <= totalDaysInMonth)
            {
                int daysLeft = totalDaysInMonth - currentDay;
                WriteLine($"Days left until the end of the month: {daysLeft}");
            }
            else
            {
                WriteLine($"Error: the day must be between 1 and {totalDaysInMonth}.");
            }
        }
        else
        {
            WriteLine("Error: Please enter a valid integer.");
        }
    }

    static void Task5()
    {
        WriteLine("\n--- Task 5 is being performed ---");
        Write("Enter the first integer: ");
        int num1 = Convert.ToInt32(ReadLine());

        Write("Enter the second integer: ");
        int num2 = Convert.ToInt32(ReadLine());

        int result = CalculateDifference(num1, num2);

        WriteLine($"Difference between numbers {num1} and {num2} equals: {result}");

        int CalculateDifference(int a, int b)
        {
            return a - b;
        }
    }

    static void Task6()
    {
        WriteLine("\n--- Task 6 is being performed ---");
        Write("Enter a real number x: ");
        double x = Convert.ToDouble(ReadLine());

        Write("Enter a valid number y: ");
        double y = Convert.ToDouble(ReadLine());

        if (x == 0 || y == 0)
        {
            WriteLine("Error: x and y cannot be zero (division by zero).");
        }
        else
        {
            double result = (1.0 / (x * y) + 1.0 / (x * x + 1.0)) * (x + y);
            WriteLine($"Meaning of the expression: {result:F4}");
        }
    }
}