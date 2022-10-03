// Задача 4: Напишите программу, которая на вход принимает число (N), 
// а на выходе показывает все чётные числа от 1 до N.

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
            
            for(int i = 1; i < a + 1; i++){
                if(i % 2 == 0){
                    Console.WriteLine(i);
                }
            }

        }
    }
}
