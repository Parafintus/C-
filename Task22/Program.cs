// Задача 22: Напишите программу, которая
// принимает на вход число (N) и выдаёт таблицу
// квадратов чисел от 1 до N.
// 5 -> 1, 4, 9, 16, 25.
// 2 -> 1,4

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
Square(number);

void Square(int num)
{
    int index = 1;
    while (index <= num)
    {
        Console.WriteLine($"{index,5} - {Math.Pow(index, 2),5}");
        index++;
    }
}


