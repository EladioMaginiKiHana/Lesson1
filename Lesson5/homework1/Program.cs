//Задача 1: 
//Задайте массив заполненный случайными положительными трёхзначными числами. 
//Напишите программу, которая покажет количество чётных чисел в массиве.
//[345, 897, 568, 234] -> 2
//

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
            int[] myArray = CreateArray(sizeArray, 100, 999);
            int countEven = 0;

            for (int i = 0; i < myArray.Length; i++)
            {
                int sum = 0;

                if (myArray[i] >= 100 && myArray[i] < 1000)
                {
                    for (int j = 0; j < 3; j++)
                    {
                        switch (j)
                        {
                            case 0:
                                sum += myArray[i] % 10;
                                break;
                            case 1:
                                sum += (myArray[i] / 10) % 10;
                                break;
                            default:
                                sum += myArray[i] / 100;
                                break;
                        }
                    }
                    if (sum % 2 == 0)
                    {
                        countEven++;
                    }
                }
            }
            Console.Write("Массив: ");
            PrintArray(myArray);
            Console.WriteLine($"Kоличество чётных чисел в массиве: {countEven}");
