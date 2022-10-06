//  Напишите программу, которая принимает на вход трёхзначное число и 
// на выходе показывает вторую цифру этого числа. Не использовать строки для расчета.

// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.Clear();

System.Console.Write("Ведите число: ");

int number = Convert.ToInt32(Console.ReadLine());
if (number > 99 & number < 1000)
{
    int result = number % 100;
    int wqer = result / 10;
    System.Console.WriteLine(wqer);
}
else    
{
    System.Console.WriteLine("Число не трехзначное");
}