// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

// [3 7 22 2 78] -> 76

double[] GetArray(int size, double minValue, double maxValue)
{
    double[] result = new double[size];
    for (int i = 0; i < size; i++)
    {
        result[i] = Math.Round(new Random().NextDouble() * (maxValue - minValue) + minValue, 2);
    }
    return result;
}

double Result(double[] inArray)
{
    double diff = 0;
    double max = inArray[0];
    double min = inArray[0];
    for (int i = 0; i < inArray.Length; i++)
    {
        if (inArray[i]>max){
            max = inArray[i];
        } if (inArray[i]<min){
            min = inArray[i];
        }
        diff = Math.Round(max-min,2);

    }
    return diff;

}

double[] array = GetArray(5,-100,100);
Console.WriteLine(String.Join(", ", array));
double diff = Result(array);
Console.WriteLine(diff);