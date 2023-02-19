﻿// 17. Напишите программу,
// которая 1.принимает на вход координаты точки (X и Y),
// причём 2.X ≠ 0 и Y ≠ 0 и
// 3.выдаёт номер четверти плоскости,
// в которой находится эта точка.

Console.WriteLine("Введите координаты точки");
Console.Write("X: ");
int xc = Convert.ToInt32(Console.ReadLine());
Console.Write("Y: ");
int yc = Convert.ToInt32(Console.ReadLine());

int quarter = Quarter(xc, yc);  // условие ? значение : значение
string result = quarter > 0
                 ? $"Указанные координаты соответсвуют четверти {quarter}"
                 : "Введены некорректные координаты";
Console.WriteLine(result);

int Quarter(int x, int y)
{
    if (x > 0 && y > 0) return 1;
    if (x < 0 && y > 0) return 2;
    if (x < 0 && y < 0) return 3;
    if (x > 0 && y < 0) return 4;
    return 0;
}