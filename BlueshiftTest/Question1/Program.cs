using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question1
{
    class Program
    {
        static void Main(string[] args)
        {
            Tests();
            while (true)
            {
                Calculation calculation = new Calculation();
                long number = GetNumber();
                switch (calculation.value)
                {
                    case "Copy":
                        Console.WriteLine(calculation.Copy(number));
                        break;
                    case "Factorial":
                        Console.WriteLine(calculation.Factorial(number));
                        break;
                    case "EvenOdd":
                        Console.WriteLine(calculation.EvenOdd(number));
                        break;
                    // Add extra Calculations here
                    default:
                        break;
                }
            }
        }

        static long GetNumber()
        {
            Console.WriteLine("Enter A Number:");
            while (true)
            {
                string numberString = Console.ReadLine();
                if (numberString == "EXIT") System.Environment.Exit(-1);
                try
                {
                    long number = Convert.ToInt64(numberString);
                    return number;
                }
                catch // Deal with user input that cannot be interpreted as a long integer
                {
                    Console.WriteLine("Enter A Number:");
                }
            }
        }

        static void Tests() // Some basic unit tests to see if the calculations work
        {
            var calculation = new Calculation();

            System.Diagnostics.Debug.Assert(calculation.Copy(-1) == "-1");

            System.Diagnostics.Debug.Assert(calculation.EvenOdd(-1) == "Odd");
            System.Diagnostics.Debug.Assert(calculation.EvenOdd(2) == "Even");

            System.Diagnostics.Debug.Assert(calculation.Factorial(-1) == "Undefined");
            System.Diagnostics.Debug.Assert(calculation.Factorial(0) == "1");
            System.Diagnostics.Debug.Assert(calculation.Factorial(3) == "6");

        }

    }
}
