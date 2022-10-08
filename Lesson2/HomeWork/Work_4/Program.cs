using System.Globalization;
using System.Security.Cryptography;
//  Напишите программу, которая принимает на вход цифру, 
// обозначающую день недели, и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет

Console.Clear();

System.Console.WriteLine("Введи имя: ");
string name = Convert.ToString(Console.ReadLine());

System.Console.WriteLine($"{name}, привет! Ты попал в игру");
System.Console.WriteLine("Где я определю по номеру недели ВЫХОДНОЙ это или НЕТ");
System.Console.WriteLine("Введи номер недели: ");
int numbeDay = Convert.ToInt32(Console.ReadLine());

if (numbeDay > 0 & numbeDay < 6)
{
    System.Console.WriteLine("ой, ой, ой, это не выходной");
}
else if (numbeDay > 5 & numbeDay < 8)
{
    System.Console.WriteLine("Еху, Яху, Эхехе, зови всех ТУСИТЬ! Это ВЫХОДНОЙ");
}
else
{
    System.Console.WriteLine("Тут два варианта: Ты еще не отошел от выходных или Ты с другой планеты ;) ");
}
