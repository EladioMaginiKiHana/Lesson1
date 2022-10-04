// Напишите программу, которая принимает на вход число и проверяет, 
// кратно ли оно одновременно 7 и 23.
// 14 -> нет 
// 46 -> нет 
// 161 -> да

Console.Clear();

int Prompt(string meseg)
{
    System.Console.WriteLine(meseg);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}
int number = Prompt("Введите число: ");

if (number % 7 == 0 && number % 23 == 0)
{
    System.Console.WriteLine($"{number} кратно 7 или 23");
}
else 
{
    System.Console.WriteLine($"{number} не кратно 7 или 23");
}