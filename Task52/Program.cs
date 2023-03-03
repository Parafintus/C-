// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.


Console.WriteLine("Укажите количество строк в массиве");
int row = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Укажите количество столбцов в массиве");
int column = Convert.ToInt32(Console.ReadLine());

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
        Console.Write("|");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j],3}, ");
            else Console.Write($"{matrix[i, j],3}");
        }
        Console.WriteLine("|");
    }
}

void PrintArrayDouble(double[] aver)
{
    Console.Write(" ");
    for (int i = 0; i < aver.Length; i++)
    {
        if (i < aver.Length - 1) Console.Write($"{aver[i]},  ");
        else Console.Write($"{aver[i],3} ");
    }
    Console.Write(" ");
}

double[] AverageOfColumn(int[,] matrix)
{
    double[] aver = new double[matrix.GetLength(1)];
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            aver[j] += matrix[i, j];
        }
        aver[j] = Math.Round(aver[j] / matrix.GetLength(0), 2, MidpointRounding.ToZero);

    }
    return aver;
}

int[,] array2d = CreateMatrixRndInt(row, column, -10, 10);
PrintMatrix(array2d);
double[] average = AverageOfColumn(array2d);
Console.WriteLine($"Среднее арифметическое каждого столбца:");
Console.WriteLine();
PrintArrayDouble(average);

