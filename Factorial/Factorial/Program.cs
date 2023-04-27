using System;

namespace Factorial
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Napiš číslo");
            int input = int.Parse(Console.ReadLine());
            Console.WriteLine("Váš skvělý faktoriál je: " + getFactorial(input));
            Console.ReadLine();

        }

        public static int getFactorial(int n)
        {
            if (n < 0)
            {
                Console.WriteLine("Negativni cislo");
            }

            int result = 1;

            for (int i = n; i >= 1; i--)
            {
                result *= i;
            }

            return result;
        }
    }
}
