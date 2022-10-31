// Задача 2. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:

// 1 4 7 2
// 5 9 2 3
// 8 4 2 4


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

string OutputValueByIndex(int rowsIndex, int columnsIndex, int[,] arrays)
{
    string error = "\nМассив в котором нужно искать значение - не существует!";
    int result = 0;

    if (arrays.GetLength(0) == 0 || arrays.GetLength(0) == 1 && arrays.GetLength(1) == 0 ||
                arrays.GetLength(1) == 0 || arrays.GetLength(1) == 1 && arrays.GetLength(0) == 0)
               {
    return error;
}
               else
{
    for (int i = 0; i < arrays.GetLength(0); i++)
    {
        for (int j = 0; j < arrays.GetLength(1); j++)
        {
            if (arrays[i, j] == arrays[rowsIndex, columnsIndex])
            {
                result = arrays[i, j];
            }
        }
    }
}

return Convert.ToString(result);

            }

            Console.Write("Введите количество рядков в двумерном массиве: ");
int rows = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите количество столбцов в двумерном массиве: ");
int columns = Convert.ToInt32(Console.ReadLine());

int[,] myArray = TheCreationOfATwoWorldToIntArray(rows, columns);

Print2DArray(myArray);

Console.WriteLine();

Console.Write($"Введите индекс рядка по которому желаете искать значение: ");
int indexRows = Convert.ToInt32(Console.ReadLine());

Console.Write($"Введите индекс столбца по которому желаете искать значение: ");
int indexColumns = Convert.ToInt32(Console.ReadLine());

try
{
    Console.Write($"Значение по индексу [{indexRows}, {indexColumns}]: ");
    Console.WriteLine(OutputValueByIndex(indexRows, indexColumns, myArray));
}
catch
{
    Console.WriteLine("Tакого числа в массиве нет");
}