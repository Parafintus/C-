// Задача 30: Напишите программу, которая
// выводит массив из 8 элементов, заполненный
// нулями и единицами в случайном порядке.
// [1,0,1,1,0,1,0,0]

Console.WriteLine("Введите количество элементов в массиве");
int number = Convert.ToInt32(Console.ReadLine());
int[] array = NewArray(number);
PrintArray(array);

int[] NewArray(int num)
{

    // int[] NewRandomArray(int num, int min, int max)
    //         {
    //             Random rand = new Random();
    //             int[] arr = new int[num];
    //             for (int i = 0; i < num; i++)
    //             {
    //                 arr[i] = rand.Next(min, max + 1);
    //             }
    //             return arr;
    //         }
    int[] arr = new int[num];
    Random rand = new Random();
    for (int i = 0; i < num; i++)
    {
        arr[i] = rand.Next(0, 2);
    }
    return arr;
}

void PrintArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]} ");
        if (i < arr.Length -1) Console.Write($", ");
    }
}
