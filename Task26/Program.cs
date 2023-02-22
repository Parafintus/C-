﻿// Задача 26: Напишите программу, которая принимает
// на вход число и выдаёт количество цифр в числе.
// 456 -> 3
// 78 -> 2
// 89126 -> 5


Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());

int digits = Digits(number);
Console.WriteLine($"В числе {number} - {digits} цифр(a,ы))");

int Digits(int num) // num = number
{
    int result = 0;
    if (num == 0) return 1;
    else
        while (num != 0)
        {
            num = num / 10;
            result = result + 1;
        }
    return result;
}