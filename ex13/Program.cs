// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

// 645 -> 5

// 78 -> третьей цифры нет

// 32679 -> 6


Console.Clear();
Console.Write("введите число: ");
int n = int.Parse(Console.ReadLine());
int m = n%10;
if (n>=100 & n<1000){
    Console.WriteLine(m);

} else {
    Console.WriteLine("третьей цифры нет");
}

