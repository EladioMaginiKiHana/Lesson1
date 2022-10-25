// Задача 1: 
//     Пользователь вводит с клавиатуры M чисел. 
//     Посчитайте, сколько чисел больше 0 ввёл пользователь. 
//     Разделить ввод данных, от расчета данных
//     (Одна функция вводит данные, другая функция подсчитывает количество положительных)
//   0, 7, 8, -2, -2-> 2
//   1, -7, 567, 89, 223-> 3

Console.Write("Введите количество чисел сколько вы хотели бы ввести: ");
int length = Convert.ToInt32(Console.ReadLine());

int[] numArr = new int[length];

int[] numInput()
{
    for (int i = 0; i < length; i++)
    {
        numArr[i] = Convert.ToInt32(Console.ReadLine());
    }
    return numArr;
}

int TheNumberOfNumbersInTheArrayIsGreaterThanZero(int[] array)
{
    int count = 0;

    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0)
        {
            count++;
        }
    }
    return count;
}

numInput();
Console.Write($"Количество чисел больше 0: {TheNumberOfNumbersInTheArrayIsGreaterThanZero(numArr)}\n");