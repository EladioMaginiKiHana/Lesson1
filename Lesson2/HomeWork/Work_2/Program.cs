// Напишите программу, которая выводит случайное трёхзначное число 
// и удаляет вторую цифру этого числа. Не использовать строки для расчета.

// 456 -> 46
// 782 -> 72
// 918 -> 98

Console.Clear();

int number = new Random().Next(100,1000);
System.Console.WriteLine($"Рамдомное выпадение трехзначного числа >>> {number} <<<");

// Код не предусмотрен для ручного ввода данных.
//
// System.Console.Write("Ведите трехзначное число: ");
// int number = Convert.ToInt32(Console.Read());
//
// При вводе данных выдает последнее число или число не связанное с данными.

int TwoNumber = ((number % 100) / 10); // - Второе число
int OneNumber = number / 100; // - Первое число
int ThreeNumber = number % 10; // - Третье число
int resultEnd = (OneNumber * 10 + ThreeNumber);
System.Console.WriteLine(resultEnd);
System.Console.Write($"Второе число {TwoNumber}");
