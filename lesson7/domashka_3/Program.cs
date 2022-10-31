// Задача 3. Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

int[,] TheCreationOfATwoWorldToIntArray(int rowsArray, int columnsArray)
{
    Random rnd = new Random();
    int[,] toIntArray = new int[rowsArray, columnsArray];

    for (int i = 0; i < toIntArray.GetLength(0); i++)
    {
        for (int j = 0; j < toIntArray.GetLength(1); j++)
        {
            toIntArray[i, j] = rnd.Next(10);
        }
    }
    return toIntArray;
}

int[,] Print2DArray(int[,] outputArray)
{
    for (int i = 0; i < outputArray.GetLength(0); i++)
    {
        for (int j = 0; j < outputArray.GetLength(1); j++)
        {
            Console.Write($"{outputArray[i, j]} ");
        }
        Console.WriteLine();
    }
    return outputArray;
}


Console.Write("Введите количество рядков в двумерном массиве: ");
int rows = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите количество столбцов в двумерном массиве: ");
int columns = Convert.ToInt32(Console.ReadLine());

int[] summ = new int[columns];

int[,] myArray = TheCreationOfATwoWorldToIntArray(rows, columns);

int count = 1;

Print2DArray(myArray);

for (int i = 0; i < rows; i++)
{
    int secondCount = 0;
    for (int j = 0; j < columns; j++)
    {
        summ[secondCount] += myArray[i, j];      //подсчет суммы колонки    
        secondCount ++;
    }

}

foreach (double elem in summ)
{
    Console.WriteLine($"Среднее арифметическое {count}-го столбца: "  + Math.Round((elem / rows), 2)); //вывод среднего для колонки

    count++;
}