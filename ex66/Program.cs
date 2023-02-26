// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму
// натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.Clear();


int Revers(int N, int M)
{
    int sum = 0;
    if (N == M) return N;
    else
    {
        return sum = N + Revers(N + 1, M);
    }

}




Console.WriteLine("введите число: ");
int N = int.Parse(Console.ReadLine()!);

Console.WriteLine("введите число: ");
int M = int.Parse(Console.ReadLine()!);

Console.WriteLine(Revers(N, M));