// // Напишите программу, которая выводит третью цифру заданного числа или сообщает,
// //  что третьей цифры нет. Не использовать строки для расчета.

// // 645 -> 5
// // 78 -> третьей цифры нет
// // 326792 -> 6

// Console.Clear();


// Console.WriteLine("Введите число: ");
// int number = Convert.ToInt32(Console.ReadLine());

// int index = 0;

// while (index < 3)
// {
//     if(a[index] == 3);
//     {
//         System.Console.WriteLine(index[2]);
//     }
//     else
//     {
//         System.Console.WriteLine("Третьей цыфры нет");
//     }
//     index++;
// }

System.Console.WriteLine("Введите число"); 
int n = Convert.ToInt32(Console.ReadLine()); 
if (n < 100) 
{ 
 Console.WriteLine("Третьей цифры нет"); 
} 
else 
{ 
 while (n >= 1000) 
 { 
 n = n/10; 
 } 
 int k = n % 10; 
 Console.WriteLine($"Третья цифра заданного равна : {k} "); 
}