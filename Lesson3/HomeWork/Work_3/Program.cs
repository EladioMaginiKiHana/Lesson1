// Напишите программу, которая принимает на вход число (N) 
// и выдаёт таблицу кубов чисел от 1 до N.

// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

Console.Clear();

int Prompt(string message)
{
    Console.Write(message);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}
int number = Prompt("Ведите номер: ");

 for (int point = 1; number >= point; point++)
{
    if (point < number)
    {
        int result = point * point * point;
        System.Console.Write(result + ", ");
    }
    if (point == number)
    {
        int result = point * point * point;
        System.Console.Write(result);
    }
}

// for (int i = 0; i < 10; i++)
//             {
//                 Console.Write(i);
//             }
        