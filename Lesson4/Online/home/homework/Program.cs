// Задача*
// Напишите программу, которая из массива случайных чисел. 
// Ищет второй максимум(число меньше максимального элемента, но больше всех остальных).
// Постарайтесь сделать одним циклом
// [1, 3, 5, 6, 6, 4]-> 5

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

try
{
    Console.Write("Введите размер массива: ");
    int sizeArr = Convert.ToInt32(Console.ReadLine());
    int[] arr = CreateArray(sizeArr, 0, 100);
    Array.Sort(arr);

    int arrLengthMultipliedBy2 = arr.Length * 2;

    int counterForTheSecondNumber = 0;

    int max = arr[0];
    int second_max = arr[counterForTheSecondNumber];


    Console.Write("Элементы в массиве: ");
    PrintArray(arr);

    if (arr.Length == 1)
    {
        Console.WriteLine($"\nМаксимальное число из массива: {arr[0]}");
        Console.WriteLine("Второго максимума нет");
    }
    else
    {
        for (int i = 0; i <= arrLengthMultipliedBy2; i++)
        {

            if (i < (arrLengthMultipliedBy2 / 2))
            {
                if (max < arr[i])
                {
                    max = arr[i];
                }
            }

            if (i > (arrLengthMultipliedBy2 / 2) && i < arrLengthMultipliedBy2)
            {
                if (second_max == max)
                {
                    counterForTheSecondNumber++;
                }
                else
                {
                    counterForTheSecondNumber++;
                    if (max != arr[counterForTheSecondNumber])
                    {
                        if (second_max <= arr[counterForTheSecondNumber])
                        {
                            second_max = arr[counterForTheSecondNumber];
                        }
                    }

                }
            }

            if (second_max != max && i == arrLengthMultipliedBy2)
            {
                Console.WriteLine($"\nМаксимальное число из массива: {max}");
                Console.WriteLine($"Второе максимальное число из массива: {second_max}");
            }
            if (second_max == max && i == arrLengthMultipliedBy2)
            {
                Console.WriteLine($"\nМаксимальное число из массива: {max}");
                Console.WriteLine("Второго максимума нет");
            }
        }
    }
}
catch
{
    Console.WriteLine("Вы ввели данные в не правильном формате. Попробуйте использывать только числа.");
}
