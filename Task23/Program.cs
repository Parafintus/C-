// Задача 23

// Напишите программу,
// которая принимает на вход число (N) и
// выдаёт таблицу кубов чисел от 1 до N.

// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
Square(number);

void Square(int num)
{
    int index = 1;
    while (index <= num)
    {
        Console.WriteLine($"{index,5} - {Math.Pow(index, 3),5}");
        index++;
    }
}