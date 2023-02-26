// Задача 68: Напишите программу вычисления функции Аккермана с помощью
// рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9

Console.Clear();

int Revers(int m, int n)
{
    if (m == 0)
    {
        return n + 1;
    }
    else if (n == 0)
    {
        return Revers(m - 1, 1);
    }
    else
    {
        return Revers(m - 1, Revers(m, n - 1));
    }
}



Console.WriteLine("введите число: ");
int m = int.Parse(Console.ReadLine()!);

Console.WriteLine("введите число: ");
int n = int.Parse(Console.ReadLine()!);

Console.WriteLine(Revers(m, n));