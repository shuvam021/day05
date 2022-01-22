using System;

namespace DayFiveAssignment
{
    internal class Program
    {
        private static void FlipCoinProgram()
        {
            int tailCount = 0;
            int headCount = 0;
            Console.Write("No of times you want to flip coin: ");
            int numOfTimes = Convert.ToInt32(Console.ReadLine());
            Random random = new Random();

            for (int i = 0; i < numOfTimes; i++)
            {
                double randomValue = random.NextDouble();
                if (randomValue < 0.5) tailCount++;
                else headCount++;
            }
            Console.WriteLine("Total tail count is " + tailCount + " out of " + numOfTimes);
            Console.WriteLine("Total head count is " + headCount + " out of " + numOfTimes);
            Console.WriteLine("Total head " + (double)(headCount * 100) / numOfTimes + "%");
            Console.WriteLine("Total tail " + (double)(tailCount * 100) / numOfTimes + "%");
        }
        private static void LeapYearProgram()
        {
            Console.Write("Insert a Year to check leap-year: ");
            int year = Convert.ToInt32(Console.ReadLine());
            if (Convert.ToString(year).Length == 4)
            {
                if (year % 400 == 0 && year % 4 == 0 && year % 100 != 0) Console.WriteLine($"{year} is leap year");
                else Console.WriteLine($"{year} is not leap year");
            }
            else Console.WriteLine("Error: insert a valid year [2022]");
        }
        private static void PowerOfTwoProgram()
        {
            Console.Write("Insert a number: ");
            int n = Convert.ToInt32(Console.ReadLine());
            if (0 <= n && n < 31)
            {
                for (int i = 1; i <= n; i++) Console.WriteLine("2^" + i + " = " + Math.Pow(2, i));
            }
            else Console.WriteLine("Error: Out of range");
        }
        private static void HarmonicNumberProgram()
        {
            Console.Write("Insert a number for harmonic value = ");
            int n = Convert.ToInt32(Console.ReadLine());
            double harmonicValue = 0;
            if (n != 0)
            {
                for (int i = 1; i <= n; i++) harmonicValue += (double)1 / i;
                Console.WriteLine("Result: Harmonic of " + n + " is = " + harmonicValue);
            }
            else Console.WriteLine("Error: value must be greater than 0");
        }
        private static void PrimeFactorsProgram()
        {
            Console.Write("Please enter an integer for prime factorial = ");
            int input = Convert.ToInt32(Console.ReadLine());
            // int j = 0;
            string factString = "";
            for (int i = 2; input > 1; i++)
                if (input % i == 0)
                {
                    while (input % i == 0) input /= i;
                    factString += $"{i} ";
                }
            Console.WriteLine(factString.Trim());
        }
        private static void QuotientAndRemainderProgram()
        {
            Console.Write("Enter 1st integer = ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter 2nd integer = ");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Quotient: {a} / {b} = {a / b}");
            Console.WriteLine($"Remainder: {a} % {b} = {a % b}");
        }
        private static void SwapTwoNumbersProgram()
        {
            Console.Write("insert number a = ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("insert number b = ");
            int b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"Pre Swap: a = {a}, and b = {b}");
            int temp = a; a = b; b = temp;
            Console.WriteLine($"Post Swap: a = {a}, and b = {b}");
        }
        private static void CheckEvenOrOddProgram()
        {
            Console.Write("insert number num = ");
            int num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(num % 2 == 0 ? $"{num} is Even" : $"{num} is Odd");
        }
        private static void CheckAlphabetIsVowelsProgram()
        {
            Console.Write("insert an alphabet: ");
            string? val = Console.ReadLine();
            if (val != null)
            {
                switch (val.ToLower())
                {
                    case "a":
                    case "e":
                    case "i":
                    case "o":
                    case "u":
                        Console.WriteLine($"{val} is a Vowel");
                        break;
                    default:
                        Console.WriteLine($"{val} is consonant");
                        break;
                }
            }
        }
        private static void FindLargestNumberProgram()
        {
            Random random = new Random();
            Console.Write("insert length of array : ");
            int len = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[len];
            for (int i = 0; i < len; i++)
            {
                arr[i] = random.Next(101, 501);
            }
            int max = 0;
            foreach (int i in arr)
            {
                Console.WriteLine(i);
                if (max <= i) max = i;
            }
            Console.WriteLine($"max value is: {max}");
        }
        static void Main(string[] args)
        {
            // FlipCoinProgram();                      // Question 01
            // LeapYearProgram();                      // Question 02
            // PowerOfTwoProgram();                    // Question 03
            // HarmonicNumberProgram();                // Question 04
            // PrimeFactorsProgram();                  // Question 05
            // QuotientAndRemainderProgram();          // Question 06
            // SwapTwoNumbersProgram();                // Question 07
            // CheckEvenOrOddProgram();                // Question 08
            // CheckAlphabetIsVowelsProgram();        // Question 09
            FindLargestNumberProgram();             // Question 10
        }
    }
}
