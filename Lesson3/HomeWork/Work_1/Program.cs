using System.Timers;
using System.Security.Cryptography;
// Задача 1
// Напишите программу, которая принимает на вход пятизначное число и проверяет, 
// является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да


System.Console.Write("Введите пятизначное число: ");

string numbers = Console.ReadLine();
int numbers_int = Convert.ToInt32(numbers);

int one_number = numbers_int / 10000; // первое число
int two_number = numbers_int / 1000 % 10; // второе число
int fourth_number = numbers_int  % 100 / 10 ; // четвертое число
int fifth_number = numbers_int % 10; // пятое число

int result_1 = one_number - fifth_number;
int result_2 = two_number - fourth_number;
int palindrome = result_1 - result_2;

if (numbers.Length == 5)
{
    if (palindrome == 0)
    {
        System.Console.WriteLine($"Число: {numbers} - палиндром");
    } 
    else 
    {
        System.Console.WriteLine($"Число: {numbers} - не палиндром");
    }
}
else
{
    System.Console.WriteLine($"Вы ввели не пятизначное число! попробуйте снова");
}