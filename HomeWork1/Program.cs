// Задача 1: Напишите программу, которая на вход принимает два числа
//  и выдаёт, какое число большее, а какое меньшее.

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
            int one_count = Convert.ToInt32(Console.ReadLine());
            int two_count = Convert.ToInt32(Console.ReadLine());
            int max = 0;
            int min = 0;
            
            if(one_count > two_count){
                 max = one_count;
                 min = two_count;
                 Console.WriteLine(max + " - more number");
                 Console.WriteLine(min + " - lesser number");
            }
            else
            {
                 min = one_count;
                 max = two_count;
                 Console.WriteLine(max + " - more number");
                 Console.WriteLine(min + " - lesser number");
            }
            
        }
    }
}