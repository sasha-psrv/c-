// Задача 58: Задайте две матрицы. Напишите программу, которая будет
// находить произведение двух матриц.


Console.Clear();
int[,] GetArray(int m, int n, int minValue, int maxValue)
{
    int[,] result = new int[m, n];

    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return result;
}

int[,] CountMatrix(int[,] firstMatrix, int[,] secondMatrix)
{
    int[,] result = new int[firstMatrix.GetLength(0), secondMatrix.GetLength(1)];

    for (int i = 0; i < firstMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < secondMatrix.GetLength(1); j++)
        {
            int value = 0;
            for (int k = 0; k < firstMatrix.GetLength(1); k++)
            {
                value += firstMatrix[i, k] * secondMatrix[k, j];
            }
            result[i, j] = value;
        }
    }
    return result;
}


void PrintArray(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Console.Write($"{inArray[i, j]}\t ");
        }
        Console.WriteLine();
    }
}


Console.WriteLine("введите кол-во строк 1 матрицы: ");
int row = int.Parse(Console.ReadLine()!);
Console.WriteLine("введите кол-во столбцов 1 матрицы: ");
int col = int.Parse(Console.ReadLine()!);

Console.WriteLine("введите кол-во строк 2 матрицы: ");
int rowSecond = int.Parse(Console.ReadLine()!);
Console.WriteLine("введите кол-во столбцов 2 матрицы: ");
int colSecond = int.Parse(Console.ReadLine()!);

int[,] array2D = GetArray(row, col, 0, 10);
PrintArray(array2D);
Console.WriteLine();
int[,] array2DSecond = GetArray(rowSecond, colSecond, 0, 10);
PrintArray(array2DSecond);
Console.WriteLine();


if (array2D.GetLength(1) == array2DSecond.GetLength(0))
{
    int[,] sum = CountMatrix(array2D, array2DSecond);
    PrintArray(sum);
}
else
{
    Console.WriteLine("невозможно перемножить");
}