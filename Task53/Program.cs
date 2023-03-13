// Задача 53: Задайте двумерный массив. Напишите программу,
// которая поменяет местами первую и последнюю строку
// массива.


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

void ReplaceFirstAndLastRows(int[,] matr)
{
    int temp = 0;
    int index = matr.GetLength(0) - 1;
    for (int i = 0; i < matr.GetLength(1); i++)
    {
        temp = matr[0, i];
        matr[0, i] = matr[index, i];
        matr[index, i] = temp;
    }
}

Console.WriteLine("Укажите количество строк в массиве");
int row = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Укажите количество столбцов в массиве");
int column = Convert.ToInt32(Console.ReadLine());
if (row < 0 || column < 0) Console.WriteLine("Ошибка ввода");
else{
int[,] array2d = CreateMatrixRndInt(row, column, -10, 10);
PrintMatrix(array2d);
Console.WriteLine();
Console.WriteLine("Измененная матрица:");
ReplaceFirstAndLastRows(array2d);
PrintMatrix(array2d);
}