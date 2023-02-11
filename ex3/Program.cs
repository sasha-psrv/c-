// 3. Показать кубы чисел, заканчивающихся на четную цифру

Console.Clear();
Console.WriteLine("введите число: ");
int N = int.Parse(Console.ReadLine()!);
if (N%2==0){
    Console.WriteLine(N*N*N);
}else{
    Console.WriteLine("не четное");
}