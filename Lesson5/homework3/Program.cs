/* Задача 3: 
    Задайте массив вещественных чисел. 
    Найдите разницу между максимальным и минимальным элементов массива.
    [3 7 22 2 78] -> 76
*/

void PrintArray(double[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1)
        {
            Console.Write($"{array[i]}; ");
        }
        else
        {
            Console.Write($"{array[i]}]");
        }
    }
    Console.WriteLine();
}

Console.Write("Введите размер массива: ");
int sizeArray = Convert.ToInt32(Console.ReadLine());
double[] arr = new double[sizeArray];
Random rnd = new Random();

for (int i = 0; i < arr.Length; i++)
{
    arr[i] = Math.Round(rnd.NextDouble(), 2);
}

double max = arr[0];
double min = arr[0];

for (int i = 0; i < arr.Length; i++)
{
    if (max < arr[i])
    {
        max = arr[i];
    }
    if (min > arr[i])
    {
        min = arr[i];
    }
}

double result = max - min;

Console.Write("Массив: ");
PrintArray(arr);
Console.WriteLine($"Max: {max}\nMin: {min}");
Console.WriteLine($"Разница между максимальным и минимальным значениями в массиве: {result}");