// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

Console.Clear();
Console.WriteLine("введите первое число: ");
int a = int.Parse(Console.ReadLine()!);
Console.WriteLine("введите второе число: ");
int b = int.Parse(Console.ReadLine()!);
Console.WriteLine("введите третье число: ");
int c = int.Parse(Console.ReadLine()!);
int max;

if (a>b){
   max = a;
} else {
    max = b;
} if (b>a) {
    max = b;
} else {
   max = a;
} if (c>a) {
    max = c; 
} else  {
    max =a;
} if (c>b) {
    max = c;
} else {
    max = b;
}
    Console.WriteLine($"Max: {max} ");
 







