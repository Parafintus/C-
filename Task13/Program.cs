// Задача 13: Напишите программу,
// которая выводит третью цифру 
// заданного числа или сообщает,
// что третьей цифры нет.

// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());

int thirdDigit = ThirdDigit(number);

if (number < 99)
    Console.WriteLine("Третьей цифры нет");
else Console.WriteLine($"{number} -> {thirdDigit}");


int ThirdDigit(int num) // num = number
{

    while (num > 1000)
    {
        num = num / 10;
    }
    return thirdDigit = num % 10;
}