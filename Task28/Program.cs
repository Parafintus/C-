// Задача 28: Напишите программу, которая
// принимает на вход число N и выдаёт
// произведение чисел от 1 до N.
// 4 -> 24
// 5 -> 120
Console.WriteLine("Введите целое положительное число");
int number = Convert.ToInt32(Console.ReadLine());

int mult = MultiplyNumbers(number);
if(number < 0) Console.WriteLine("Введено ненатуральное число");
else Console.WriteLine($"Произведение чисел от 1 до {number} равно {mult}");

int MultiplyNumbers(int num)
{
    int sum = 1;
    for (int i = 1; i <= num; i++)
    {
        checked
        {
            sum = sum * i;
        }
    }
    return sum;
}