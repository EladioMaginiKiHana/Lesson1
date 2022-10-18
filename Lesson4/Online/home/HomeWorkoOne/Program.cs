/* Задача 1: 
 Напишите цикл, который принимает на вход два числа(A и B) 
 И возводит число A в натуральную степень B(и в нулевую степень). 
 Использовать свои функции, не использовать Math.Pow

3, 5-> 243(3⁵)

2, 4-> 16 */


Console.WriteLine("Эта программа возводит число А в степень В.");

try
{

    Console.Write("Введите число А: ");
    int a = Convert.ToInt32(Console.ReadLine());

    Console.Write("Введите число В: ");
    int b = Convert.ToInt32(Console.ReadLine());

    int c = a;

    if (0 == b)
    {
        Console.WriteLine($"Число {a} в степени {b} = 1");
    }
    else
    {
        for (int i = 1; i < b; i++)
        {
            c *= a;
        }
        Console.WriteLine($"Число {a} в степени {b} = {c}");
    }
}
catch
{
    Console.WriteLine("Введеный вами формат не верен. \nПопробуйте убрать все лишние символы и ввести исключительно числа.");
}