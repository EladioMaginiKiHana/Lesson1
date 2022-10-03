// Задача 2: Напишите программу, 
// которая принимает на вход три числа и выдаёт максимальное из этих чисел.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Sololearn
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            int c = Convert.ToInt32(Console.ReadLine());
            int max, min, mid;

            if (a > b && a > c)
            {
                max = a;
                min = (b < c) ? b : c;
                Console.WriteLine(max);
            }
            else if (b > a && b > c)
            {
                max = b;
                min = (a < c) ? a : c;
                Console.WriteLine(max);
            }
            else
            {
                max = c;
                min = (b < a) ? a : b;
                Console.WriteLine(max);
            }

        }
    }
}