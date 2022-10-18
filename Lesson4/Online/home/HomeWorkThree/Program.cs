// Задача 3: 
// Напишите программу, которая задаёт массив из 8 случайных элементов и выводит их на экран.

int[] arr = new int[8];

Random rnd = new Random();

for (int i = 0; i < arr.Length; i++)
{
    arr[i] = rnd.Next(0, 11);
    if (i < arr.Length - 1)
    {
        Console.Write($"{arr[i]}, ");
    }
    if (i < arr.Length)
    {
        Console.Write(arr[i]);
    }
}
Console.WriteLine();
