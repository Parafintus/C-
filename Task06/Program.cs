﻿Console.WriteLine("Введите натуральное число");
int number = Convert.ToInt32(Console.ReadLine());
if (number % 2 == 0)
{
    Console.WriteLine($"Число {number} является четным");
}
else Console.WriteLine($"Число {number} не является четным");
