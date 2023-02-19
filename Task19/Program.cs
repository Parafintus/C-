// Задача 19
// Напишите программу,
// которая принимает на вход пятизначное число и
// проверяет, является ли оно палиндромом.

// 14212 -> нет

// 12821 -> да

// 23432 -> да


Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());
if (Palindrome(number)) Console.WriteLine("ДА");
else Console.WriteLine("НЕТ");

bool Palindrome(int num)
{
    int numberTemp = num;
    int value;
    int numberRevers = 0;
    while (numberTemp > 0)
    {
        value = numberTemp % 10;
        numberRevers = numberRevers * 10 + value;
        numberTemp /= 10;
    }
    if (numberRevers == num)
    {
        return true;
    }
    else
    {
        return false;
    }
}

