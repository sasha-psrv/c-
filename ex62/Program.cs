﻿// Задача 62: Заполните спирально массив 4 на 4.


void ArraySpiral(int[,] array, int n)
{
    int i = 0, j = 0;
    int value = 1;
    for (int m = 0; m < n * n; m++)
    {
        int k = 0;
        do { array[i, j++] = value++; } while (++k < n - 1);
        for (k = 0; k < n - 1; k++) array[i++, j] = value++;
        for (k = 0; k < n - 1; k++) array[i, j--] = value++;
        for (k = 0; k < n - 1; k++) array[i--, j] = value++;
        ++i; ++j;
        n = n < 2 ? 0 : n - 2;
    }
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i, j] < 10)
            {
                Console.Write("0" + array[i, j]);
                Console.Write(" ");
            }
            else Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
}
Console.WriteLine("Введите число");
int lenght = int.Parse(Console.ReadLine()!);
int[,] array = new int[lenght, lenght];
ArraySpiral(array, lenght);
PrintArray(array);