// Задача 27:
// Напишите программу,
// которая принимает на вход число и
// выдаёт сумму цифр в числе.

// 452 -> 11

// 82 -> 10

// 9012 -> 12


Console.WriteLine("Введите натуральное число");
int number = Convert.ToInt32(Console.ReadLine());
int sumdigits = SumDigits(number);
if(number <= 0) Console.WriteLine("Введено некорректное число");
else Console.WriteLine($"Сумма цифр числа {number} равна {sumdigits}");

int SumDigits(int num) // num = number
{
    int result = 0;
    while (num > 0)
    {
        result = result + num % 10;
        num = num / 10;
    }
    return result;
}