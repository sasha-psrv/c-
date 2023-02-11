// 1.Подсчитать сумму цифр в числе
Console.Clear();
Console.WriteLine("введите число: ");
int N = int.Parse(Console.ReadLine()!);
int res = 0;
for (int i = 0; i <= N; i++)
{
    res += i;
}
Console.WriteLine(res);
