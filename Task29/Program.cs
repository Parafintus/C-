// Напишите программу,
// которая задаёт массив из 8 элементов
// и выводит их на экран.

// 1, 2, 5, 7, 19, 6, 1, 33 -> [1, 2, 5, 7, 19, 6, 1, 33]

Console.WriteLine("Введите количество элементов в массиве");
int number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите максимальное число в массиве");
int maxNumber = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите минимальное число в массиве");
int minNumber = Convert.ToInt32(Console.ReadLine());
int[] array = NewArray(number, maxNumber, minNumber);
PrintArray(array);

int[] NewArray(int num, int max, int min)
{

    Random rand = new Random();
    int[] arr = new int[num];
    for (int i = 0; i < num; i++)
    {
        arr[i] = rand.Next(min, max + 1);
    }
    return arr;
}


void PrintArray(int[] arr)
{
    for (int j = 0; j < arr.Length -1; j++)
    {
        Console.Write($"{arr[j]},  ");
    }
    Console.Write($"{arr[arr.Length - 1]} ");
    Console.Write("-> [");
    for (int i = 0; i < arr.Length - 1; i++)
    {
        Console.Write($"{arr[i]},  ");
    }
    Console.Write($"{arr[arr.Length - 1]}");
    Console.Write($"]");


}
