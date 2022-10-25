/*Задача 2: 
  Задайте одномерный массив, заполненный случайными числами. 
 Найдите сумму элементов, стоящих на нечётных позициях.
 [3, 7, 23, 12] -> 19
 [-4, -6, 89, 6] -> 0
 */

void PrintArray(int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1)
        {
            Console.Write($"{array[i]}, ");
        }
        else
        {
            Console.Write($"{array[i]}]");
        }
    }
    Console.WriteLine();
}

int[] CreateArray(int len, int minLimit, int maxLimit)
{
    int[] array = new int[len];
    Random rnd = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.Next(minLimit, maxLimit + 1);
    }
    return array;
}

Console.Write("Введите размер массива: ");

int sizeArray = Convert.ToInt32(Console.ReadLine());
int[] myArray = CreateArray(sizeArray, 0, 100);
int sumEven = 0;
int sumOdd = 0;

for (int i = 0; i < myArray.Length; i++)
{
    if (i % 2 == 0)
    {
        sumEven += myArray[i];
    }
    else
    {
        sumOdd += myArray[i];
    }
}

Console.Write("Массив: ");
PrintArray(myArray);
Console.WriteLine($"Сумма элементов, стоящих на чётных позициях: {sumEven}");
Console.WriteLine($"Сумма элементов, стоящих на нечётных позициях: {sumOdd}");