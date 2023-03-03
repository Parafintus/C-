// Задача 50.
// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
// и возвращает значение этого элемента или же указание, что такого элемента нет.

// Например, задан массив:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// 1, 7 -> такого элемента в массиве нет

Console.WriteLine("Укажите количество строк в массиве");
int row = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Укажите количество столбцов в массиве");
int column = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Укажите позицию по строке в массиве");
int rowIndex = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Укажите позицию по столбцу в массиве");
int columnIndex = Convert.ToInt32(Console.ReadLine());


int[,] CreateMatrixRndInt(int rows, int columns, int min, int max)
{
    int[,] matrix = new int[rows, columns]; // 0 ,  1
    Random rnd = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++) // rows
    {
        for (int j = 0; j < matrix.GetLength(1); j++) // columns
        {
            matrix[i, j] = rnd.Next(min, max + 1);
        }
    }
    return matrix;
}


void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write(" ");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j],3}, ");
            else Console.Write($"{matrix[i, j],3}");
        }
        Console.WriteLine(" ");
    }
}

if (row < 1 || column < 1 || rowIndex < 0 || columnIndex < 0 ) Console.WriteLine("Ошибка ввода");
else if (rowIndex > row-1 || columnIndex > column-1) Console.WriteLine("Такого элемента в массиве нет");
else {
int[,] array2d = CreateMatrixRndInt(row, column, -10, 10);
PrintMatrix(array2d);
Console.WriteLine();
Console.WriteLine($"Значение на заданной позиции элемента [{rowIndex},{columnIndex}] => {array2d[rowIndex, columnIndex]}");
}