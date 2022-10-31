// Задача 1. Задайте двумерный массив размером m×n, 
// заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

Random rnd = new Random();

Console.Write("Введите количество рядков в двумерном массиве: ");
int rows = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите количество столбцов в двумерном массиве: ");
int columns = Convert.ToInt32(Console.ReadLine());

double[,] myArray = new double[rows, columns];

for (int i = 0; i < myArray.GetLength(0); i++)
{
    for (int j = 0; j < myArray.GetLength(1); j++)
    {
        myArray[i, j] = rnd.Next(-100, 101) - Math.Round(rnd.NextDouble(), 1);
        Console.Write($"{myArray[i, j]} ");
    }
    Console.WriteLine();
}