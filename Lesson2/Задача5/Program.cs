// Напишите программу, которая выводит случайное число из отрезка [10, 99]
//  и показывает наибольшую цифру числа.
// 78 -> 8 
// 12-> 2 
// 85 -> 8

Console.Clear();

int Prompt(string meseg)
{
    System.Console.WriteLine(meseg);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

int a = new Random().Next(10,100);
System.Console.WriteLine(a);
int max = a % 10;
while (a > 0)
{
    int temp = a % 10;
    if (temp > max)
    {
        max = temp;
    }   
        
    a = a % 10;
}
System.Console.WriteLine($"Максимум цифра {max}");