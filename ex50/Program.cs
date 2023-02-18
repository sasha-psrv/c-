// Задача 50: Напишите программу, которая на вход
// принимает позиции элемента в двумерном массиве, и
// возвращает значение этого элемента или же указание,
// что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

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

void SerchNumb(int[,] arr, int str, int stolb)
{
    if (arr.GetLength(0) > str & arr.GetLength(1) > stolb)
    {
        Console.WriteLine(arr[str, stolb]);
    }
    else
    {
        Console.WriteLine("такого числа в массиве нет");
    }

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

int[,] array2D = GetArray(row, col, -10, 10);

Console.WriteLine("введите номер строки: ");
int str = int.Parse(Console.ReadLine()!)-1;
Console.WriteLine("введите номер столбца: ");
int stolb = int.Parse(Console.ReadLine()!)-1;


PrintArray(array2D);
SerchNumb(array2D, str, stolb);
