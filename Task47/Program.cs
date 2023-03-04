﻿// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

// m = 3, n = 4.

// 0,5 7 -2 -0,2

// 1 -3,3 8 -9,9

// 8 7,8 -7,1 9

Console.WriteLine("Укажите количество строк в массиве");
int row = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Укажите количество столбцов в массиве");
int column = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Укажите количество символов после запятой");
int count = Convert.ToInt32(Console.ReadLine());
if (count < 0 || row < 1 || column < 0) Console.WriteLine("Ошибка ввода");

double[,] CreateMatrixRndDouble(int rows, int columns, int min, int max)
{
    double[,] matrix = new double[rows, columns]; // 0 ,  1
    Random rnd = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++) // rows
    {
        for (int j = 0; j < matrix.GetLength(1); j++) // columns
        {
            matrix[i, j] = Math.Round((rnd.NextDouble() * (max - min) + min), count, MidpointRounding.ToZero);
        }
    }
    return matrix;
}

void PrintMatrix(double[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("|");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j], 7}, ");
            else Console.Write($"{matrix[i, j], 7}");
        }
        Console.WriteLine("|");
    }
}

double[,] array2d = CreateMatrixRndDouble(row, column, -100, 100);
PrintMatrix(array2d);
