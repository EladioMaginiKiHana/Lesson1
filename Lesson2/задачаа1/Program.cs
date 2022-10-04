using System.Reflection.Metadata;
using System;
// 1. Напишите программу, которая принимает на вход трёхзначное 
// число и на выходе показывает последнюю цифру этого числа.
// 456 -> 6
// 782 -> 2
// 918 -> 8
System.Console.WriteLine("Ведите число: "); // поставить условие для ввода данных

int numberA = Convert.ToInt32(Console.ReadLine()); // Прием вводных данных

if (numberA > 99 & numberA < 1000) // Условие проверки 
{
    int result = numberA % 10; //  последная цыфры 
    System.Console.WriteLine(result); // Вывод результата
}
else // проверка данных не прошла
{
    System.Console.WriteLine("Число не трех значное"); // Вывод принеправльном результате данных
}