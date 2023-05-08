using System;

namespace MultiplicationTable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Multiplication Table";
            Console.WriteLine("Enter number:");
            int number = int.Parse(Console.ReadLine());
            for (int i = 0; i <= number; i++)
            {
                for (int j = 0; j <= number; j++)
                {
                    Console.Write(i * j + " ");
                }
                Console.WriteLine();
            }

            Console.ReadLine();

        }

    }

}
