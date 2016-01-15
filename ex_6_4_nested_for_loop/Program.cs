using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex_6_4_nested_for_loop
{
    class Program
    {
        static void Main()
        {
            /*6-4  Write a program that reads from the console a
            positive integer number N (N < 20) and prints a matrix 
            of numbers as in the figures in the book. (Chapter 6, Exercise 10)
            */

            Console.WriteLine("What number would you like to end your matrix?");
            int n = int.Parse(Console.ReadLine());

            for (int x = 1; x <= n; x++)
            {
                for (int y = 0; y < n; y++)
                {
                    Console.Write(x + y + " ");
                }
                Console.WriteLine();
            }
            Console.ReadKey();

        }
    }
}
