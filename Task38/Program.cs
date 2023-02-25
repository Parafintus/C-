// Задача 38:
// Задайте массив вещественных чисел.
// Найдите разницу между максимальным
// и минимальным элементов массива.

// [3.5, 7.1, 22.9, 2.3, 78.5] -> 76.2

double[] CreateArrayRndDouble(int size, int min, int max)
{
    double[] arr = new double[size];
    Random rnd = new Random();
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = Math.Round((rnd.NextDouble() * (max - min) + min), 2, MidpointRounding.ToZero);
    }
    return arr;
}

void PrintArrayDouble(double[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1) Console.Write($"{arr[i]}, ");
        else Console.Write($"{arr[i]}");
    }
    Console.Write("]");
}

double MaxElem(double[] arr)
{
    double max = arr[0];
    for (int i = 1; i < arr.Length; i++)
    {
        if (arr[i] > max) max = arr[i];
    }
    return max;
}

double MinElem(double[] arr)
{
    double min = arr[0];
    for (int i = 1; i < arr.Length; i++)
    {
        if (arr[i] < min) min = arr[i];
    }
    return min;
}

double[] array = CreateArrayRndDouble(5, 0, 99);
PrintArrayDouble(array);
Console.WriteLine();
double maxElem = MaxElem(array);
double minElem = MinElem(array);
double difference = Math.Round(maxElem - minElem,2, MidpointRounding.ToZero);

Console.WriteLine($"разница между максимальным {maxElem} и минимальным {minElem} элементами массива = {difference}");