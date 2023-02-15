//     Задача 10:
// Напишите программу,
// которая принимает на вход трёхзначное число
// и на выходе показывает вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1


Console.WriteLine("Введите трехзначное число");
int number = Convert.ToInt32(Console.ReadLine());
int secondDigit = SecondDigit(number);

if (number >= 100 && number <= 999)
{
    Console.WriteLine($"{number} -> {secondDigit}");
}
else Console.WriteLine("Ошибка ввода");



int SecondDigit(int num) // num = number
{
    return secondDigit = num / 10 % 10;
}

