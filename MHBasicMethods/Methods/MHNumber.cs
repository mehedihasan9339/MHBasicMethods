using System;
using System.Collections.Generic;
using System.Text;

namespace MHBasicMethods.Methods
{
    public class MHNumber
    {
        private static string[] units = { "Zero", "One", "Two", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine", "Ten", "Eleven", "Twelve", "Thirteen", "Fourteen", "Fifteen", "Sixteen", "Seventeen", "Eighteen", "Nineteen" };
        private static string[] tens = { "", "", "Twenty", "Thirty", "Forty", "Fifty", "Sixty", "Seventy", "Eighty", "Ninety" };

        public string ConvertNumberToWords(int number)
        {
            if (number < 20)
            {
                return units[number];
            }

            if (number < 100)
            {
                return tens[number / 10] + (number % 10 != 0 ? " " + units[number % 10] : "");
            }

            if (number < 1000)
            {
                return units[number / 100] + " Hundred" + (number % 100 != 0 ? " and " + ConvertNumberToWords(number % 100) : "");
            }

            if (number < 1000000)
            {
                return ConvertNumberToWords(number / 1000) + " Thousand" + (number % 1000 != 0 ? " " + ConvertNumberToWords(number % 1000) : "");
            }

            if (number < 1000000000)
            {
                return ConvertNumberToWords(number / 1000000) + " Million" + (number % 1000000 != 0 ? " " + ConvertNumberToWords(number % 1000000) : "");
            }

            return "Number out of range";
        }








        public List<int> FindPrimeNumbers(int n)
        {
            List<int> primes = new List<int>();
            bool[] isPrime = new bool[n + 1];

            for (int i = 2; i <= n; i++)
            {
                isPrime[i] = true;
            }

            for (int p = 2; p * p <= n; p++)
            {
                if (isPrime[p])
                {
                    for (int i = p * p; i <= n; i += p)
                    {
                        isPrime[i] = false;
                    }
                }
            }

            for (int i = 2; i <= n; i++)
            {
                if (isPrime[i])
                {
                    primes.Add(i);
                }
            }

            return primes;
        }





        public int CalculateFactorial(int n)
        {
            if (n == 0)
                return 1;
            else
                return n * CalculateFactorial(n - 1);
        }





        public List<int> GenerateFibonacciSeries(int n)
        {
            List<int> fibonacciSeries = new List<int> { 0, 1 };
            while (fibonacciSeries.Count < n)
            {
                int sum = fibonacciSeries[fibonacciSeries.Count - 1] + fibonacciSeries[fibonacciSeries.Count - 2];
                fibonacciSeries.Add(sum);
            }
            return fibonacciSeries;
        }






        public int FindGCD(int a, int b)
        {
            while (b != 0)
            {
                int temp = b;
                b = a % b;
                a = temp;
            }
            return a;
        }





        public double CalculatePower(double baseNumber, int exponent)
        {
            if (exponent == 0)
                return 1;
            else if (exponent > 0)
                return baseNumber * CalculatePower(baseNumber, exponent - 1);
            else
                return 1 / CalculatePower(baseNumber, -exponent);
        }





        public bool IsArmstrongNumber(int number)
        {
            int originalNumber, remainder, result = 0;
            originalNumber = number;

            while (originalNumber != 0)
            {
                remainder = originalNumber % 10;
                result += (int)Math.Pow(remainder, 3);
                originalNumber /= 10;
            }

            return result == number;
        }











        public int FindLCM(int a, int b)
        {
            return (a * b) / FindGCD(a, b);
        }







        public bool IsPalindrome(int number)
        {
            int originalNumber = number;
            int reversedNumber = 0;
            while (number > 0)
            {
                int digit = number % 10;
                reversedNumber = reversedNumber * 10 + digit;
                number /= 10;
            }
            return originalNumber == reversedNumber;
        }






        public bool IsPerfectNumber(int number)
        {
            int sum = 1;
            for (int i = 2; i * i <= number; i++)
            {
                if (number % i == 0)
                {
                    sum += i;
                    if (i * i != number)
                    {
                        sum += number / i;
                    }
                }
            }
            return sum == number;
        }









        public double CalculateSquareRoot(double number)
        {
            if (number < 0)
                throw new ArgumentException("Invalid input");

            double guess = number / 2;
            double prevGuess;
            do
            {
                prevGuess = guess;
                guess = (guess + number / guess) / 2;
            } while (Math.Abs(guess - prevGuess) > double.Epsilon);
            return guess;
        }






        public string DecimalToBinary(int decimalNumber)
        {
            if (decimalNumber == 0)
                return "0";

            string binary = "";
            while (decimalNumber > 0)
            {
                int remainder = decimalNumber % 2;
                binary = remainder + binary;
                decimalNumber /= 2;
            }
            return binary;
        }







        public bool IsPowerOfTwo(int number)
        {
            return (number != 0) && ((number & (number - 1)) == 0);
        }







        public int CountDigits(int number)
        {
            return number.ToString().Length;
        }



        public double CalculateExponentiation(double baseNumber, int exponent)
        {
            if (exponent == 0)
                return 1;
            else if (exponent > 0)
                return Math.Pow(baseNumber, exponent);
            else
                return 1 / Math.Pow(baseNumber, -exponent);
        }






        public bool IsHappyNumber(int number)
        {
            HashSet<int> seen = new HashSet<int>();
            while (number != 1 && !seen.Contains(number))
            {
                seen.Add(number);
                int sum = 0;
                while (number > 0)
                {
                    int digit = number % 10;
                    sum += digit * digit;
                    number /= 10;
                }
                number = sum;
            }
            return number == 1;
        }



        public bool IsHarshadNumber(int number)
        {
            int sumOfDigits = 0;
            int n = number;
            while (n > 0)
            {
                sumOfDigits += n % 10;
                n /= 10;
            }
            return number % sumOfDigits == 0;
        }










        public List<int> GeneratePrimesInRange(int start, int end)
        {
            bool[] isPrime = new bool[end + 1];
            for (int i = 2; i <= end; i++)
            {
                isPrime[i] = true;
            }

            for (int p = 2; p * p <= end; p++)
            {
                if (isPrime[p])
                {
                    for (int i = p * p; i <= end; i += p)
                    {
                        isPrime[i] = false;
                    }
                }
            }

            List<int> primesInRange = new List<int>();
            for (int i = Math.Max(2, start); i <= end; i++)
            {
                if (isPrime[i])
                {
                    primesInRange.Add(i);
                }
            }

            return primesInRange;
        }






    }
}
