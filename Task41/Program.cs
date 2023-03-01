// Задача 41:
// Пользователь вводит с клавиатуры M чисел.
// Посчитайте, сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2

// 1, -7, 567, 89, 223-> 3

Console.WriteLine("Введите размер массива");
int number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введие элемент");
int[] CreateArrayRndInt(int size)
{
    int[] arr = new int[size];
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = Convert.ToInt32(Console.ReadLine());
    }
    return arr;
}

void PrintArray(int[] arr)

{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1) Console.Write($"{arr[i]}, ");
        else Console.Write(arr[i]);
    }
    Console.Write("]");
}

int NaturalNumber(int[] arr)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] < 0) count++;
    }
    return count;
}

int[] array = CreateArrayRndInt(number);
PrintArray(array);
Console.WriteLine();
int naturalNumber = NaturalNumber(array);
Console.WriteLine($"В массиве чисел больше 0 -> {naturalNumber}");