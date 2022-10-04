// . Напишите программу, которая выводит случайное число из отрезка [10, 99] и показывает наибольшую цифру числа.
// 78 -> 8 
// 12-> 2 
// 85 -> 8

int run = new Random().Next(10,100);
Console.WriteLine(run);
int run1 = rnd % 10;
int run2 = rnd / 10;

if (run2 >run1)
{
    Console.WriteLine($"первое")
}