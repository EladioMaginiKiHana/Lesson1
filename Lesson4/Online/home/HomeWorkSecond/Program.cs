// Задача 2: 
// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе. 
// Функция должна на вход принимать число, а выдавать сумму его цифр
// 452-> 11
// 82-> 10
// 9012-> 12

int sumNumbers(int value)
{
    if (value < 10 && value >= 0)
        return value;
    int digit = value % 10;
    int nextValue = value / 10;
    return digit + sumNumbers(nextValue);
}

Console.Write("Введите число, чтобы найти сумму его чисел: ");
int numbers = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Сумма цифр введеного вами числа: {sumNumbers(numbers)}");