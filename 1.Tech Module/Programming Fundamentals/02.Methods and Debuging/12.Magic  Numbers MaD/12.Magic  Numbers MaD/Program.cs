using System;
namespace _12.Magic__Numbers_MaD
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            
            for (int i = 1; i <= number; i++)
            {
                if (isPalindrome(i) && isDivisibleBy7(i) && isEven(i)) 
                {
                    Console.WriteLine(i);
                }

            }
        }
        public static bool isPalindrome(int number)
        {
            bool isPalindrome = true;
            string numAsString = number.ToString();
            for (int i = 0; i < numAsString.Length/2; i++)
            {
                if (numAsString[i]!=numAsString[numAsString.Length -1 - i])
                {
                    isPalindrome = false;
                    break;
                }
            }
            return isPalindrome;
            
        }
        public static bool isDivisibleBy7(int number)
        {
            int sumOfDigits = 0;
            while (number > 0)
            {
                int digit = number % 10;
                sumOfDigits += digit;
                number = number / 10;

            }
            if (sumOfDigits % 7 == 0)
            {
                return true;
            }
            return false;
            
        }
        public static bool isEven (int number)
        {
            int evenNum = 0;
            while (number > 0)
            {
                int digit = number % 10;
                number = number / 10;
                evenNum = digit % 2;
                if (evenNum == 0)
                {
                    return true;
                }
                
            }
            return false;

        }
    }
}
