// Задача 21

// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

// A (3,6,8); B (2,1,-7), -> 15.84

// A (7,-5, 0); B (1,-1,9) -> 11.53


Console.Clear();
Console.Write("введите x1: ");
int x1 = int.Parse(Console.ReadLine()!);
Console.Write("введите y1: ");
int y1 = int.Parse(Console.ReadLine()!);
Console.Write("введите d1: ");
int d1 = int.Parse(Console.ReadLine()!);
Console.Write("введите x2: ");
int x2 = int.Parse(Console.ReadLine()!);
Console.Write("введите y2: ");
int y2 = int.Parse(Console.ReadLine()!);
Console.Write("введите d2: ");
int d2 = int.Parse(Console.ReadLine()!);
double res = Math.Sqrt(Math.Pow(x1-x2,2)+Math.Pow(y1-y2,2)+Math.Pow(d1-d2,2));
Console.WriteLine($"{res:f2}");