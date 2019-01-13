using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question1
{
    class Calculation
    {
        public static String[] modes = new[] { "Copy", "EvenOdd", "Factorial" }; // Add extra calcuations here

        public string value;

        public Calculation()
        {
            value = GetCalculation();
        }

        private string GetCalculation()
        {
            while (true)
            {
                Console.WriteLine("Select calculation mode:");
                Console.WriteLine(String.Join(", ", modes));
                string calculation = Console.ReadLine();
                if (calculation == "EXIT") System.Environment.Exit(-1);
                if (Calculation.modes.Contains(calculation)) // Ignore invalid entries for calculation
                    return calculation;
            }
        }

        public string Copy(long number)
        {
            return number.ToString();
        }

        public string Factorial(long number)
        {
            if (number < 0)
                return "Undefined"; // Deal with special case of negative numbers.
            else if (number>20)
                return "Overflow"; // Deal with special case of overflow.
            else
                return FactorialInternal(number).ToString();
        }

        private long FactorialInternal(long number)
        {
            if (number < 1)
                return 1;
            else
                return number * FactorialInternal(number - 1);
        }

        public string EvenOdd(long number)
        {
            if (number % 2 == 0)
                return "Even";
            else
                return "Odd";
        }


    }
}
