// Задача 56: Задайте прямоугольный двумерный массив. Напишите
// программу, которая будет находить строку с наименьшей суммой элементов.

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

int MinRowElements(int[,] inArray)
{
    int result = 1;
    int minSumRow = 0;
    int sum = 0;
    for (int m = 0; m < inArray.GetLength(1); m++)
    {
        minSumRow += inArray[0, m];
    }
    for (int i = 1; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            sum += inArray[i, j];

        }
        if (sum < minSumRow)
        {
            minSumRow = sum;
            result = i + 1;
        }
        sum = 0;
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




Console.WriteLine("введите кол-во строк: ");
int row = int.Parse(Console.ReadLine()!);
Console.WriteLine("введите кол-во столбцов: ");
int col = int.Parse(Console.ReadLine()!);

int[,] array2D = GetArray(row, col, 0, 10);

PrintArray(array2D);
Console.WriteLine();
Console.WriteLine(MinRowElements(array2D));