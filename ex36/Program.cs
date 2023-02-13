﻿// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19

// [-4, -6, 89, 6] -> 0

int[] GetArray(int size, int minValue, int maxValue)
{
    int[] result = new int[size];
    for (int i = 0; i < size; i++)
    {
        result[i] = new Random().Next(minValue, maxValue + 1);
    }
    return result;
}

int summ(int[] inArray)
{
    int count = 0;
    for (int i = 1; i < inArray.Length; i=i+2)
    {
        
        count += inArray[i];
        
    }
    return count;
}



int[] array = GetArray(5, -100, 100);
Console.WriteLine(String.Join(", ", array));
int count = summ(array);
Console.WriteLine(count);