// Задача 60: Сформируйте трёхмерный массив из неповторяющихся
// двузначных чисел. Напишите программу, которая будет построчно выводить
// массив, добавляя индексы каждого элемента.


void GetArray(int[,,] inArray)
{
     int count = int.Parse(Console.ReadLine()!);
    for (int i = 0; i <inArray.GetLength(0) ; i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            for (int k = 0; k < inArray.GetLength(2); k++)
            {
                inArray[k, i, j] += count;
                count += 3;
            }
        }
    }
}

void PrintArray(int[,,] inArray)
{
    for(int i =0; i<inArray.GetLength(0); i++)
    {
        for(int j = 0; j<inArray.GetLength(1); j++)
        {
            Console.WriteLine();
            for (int k = 0; k < inArray.GetLength(2); k++)
            {
                Console.Write($"{inArray[i, j, k]} ({i},{j},{k}) ");
            }
        }
    }
}

int[,,] array = new int[2, 2, 2];
Console.Write("Введите число: ");
GetArray(array);
PrintArray(array);