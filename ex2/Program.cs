// 2. Написать программу вычисления произведения чисел от 1 до N

Console.Clear();
Console.WriteLine("введите число: ");
int N = int.Parse(Console.ReadLine()!);
int res = 1;
for (int i = 1; i <= N; i++)
{
    res *= i;
}
Console.WriteLine(res);