// // Задача 2
// // Напишите программу, которая принимает на вход координаты двух точек и 
// // находит расстояние между ними в 3D пространстве.

// // A (3,6,8); B (2,1,-7), -> 15.84
// // A (7,-5, 0); B (1,-1,9) -> 11.53

Console.Clear();
// Math.Sqrt() // команда квадратный корень

const int X = 0;
const int Y = 1;
const int Z = 2;

int Prompt(string message)
{
    Console.Write(message);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

int[] InputPoint(int point)
{
    int[] answer = new int[3];
    answer[X] = Prompt($"Введите x {point} -> ");
    answer[Y] = Prompt($"Введите y {point} -> ");
    answer[Z] = Prompt($"Введите z {point} -> ");
    return answer;
}
int Power2(int arg)
{
    return arg * arg;
}

int[] p1 = InputPoint(1);
int[] p2 = InputPoint(2);

double lenght = Math.Sqrt(Power2(p1[X] - p2[X]) + Power2(p1[Y] - p2[Y]) + Power2(p1[Z] - p2[Z])); // <- Math.Sqrt


System.Console.WriteLine($"{lenght:f2}");


/* Console.WriteLine("Приветствую, юзер!\nЭта программа принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.");

            int x1 = Coordinate("x", "A");
            int y1 = Coordinate("y", "A");
            int z1 = Coordinate("z", "A");
            int x2 = Coordinate("x", "B");
            int y2 = Coordinate("y", "B");
            int z2 = Coordinate("z", "B");

            int Coordinate(string coorName, string pointName)
            {
                Console.Write($"Введите координаты {coorName} точки {pointName}: ");
                return Convert.ToInt32(Console.ReadLine());
            }

            double Decision(double X1, double X2,
                            double Y1, double Y2,
                            double Z1, double Z2)
            {
                return Math.Sqrt(Math.Pow((x2 - x1), 2) +
                                 Math.Pow((y2 - y1), 2) +
                                 Math.Pow((z2 - z1), 2));
            }

            double segmentLength = Math.Round(Decision(x1, x2, y1, y2, z1, z2), 2);

            Console.WriteLine($"Длина отрезка  {segmentLength}"); */