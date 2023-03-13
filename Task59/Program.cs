// Задача 59: Задайте двумерный массив из целых чисел.
// Напишите программу, которая удалит строку и столбец, на
// пересечении которых расположен наименьший элемент
// массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Наименьший элемент - 1, на выходе получим
// следующий массив:
// 9 2 3
// 4 2 4
// 2 6 7

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

int[] IndexOfMinElem(int[,] matrix)
{

    int row = 0;
    int column = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (matrix[i, j] <= matrix[row, column])
            {
                row = i;
                column = j;
            }
        }
    }

    return new int[] { row, column };
}

int[,] DeleteRowColumn(int[] array, int[,] matrix)
{
    int[,] newMatrix = new int[matrix.GetLength(0) - 1, matrix.GetLength(1) - 1];
    int m = 0, n = 0;

    for (int i = 0; i < newMatrix.GetLength(0); i++)
    {
        if (m == array[0]) m++;
        // if (i == array[0]) continue;
        for (int j = 0; j < newMatrix.GetLength(1); j++)
        {
            if (n == array[1]) n++;
            newMatrix[i, j] = matrix[m, n];
            n++;
        }
        m++;
        n = 0;
    }
    return newMatrix;
}

Console.WriteLine("Укажите количество строк в массиве");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Укажите количество столбцов в массиве");
int columns = Convert.ToInt32(Console.ReadLine());

int[,] array2d = CreateMatrixRndInt(rows, columns, -10, 10);
int[] indexOfMinElem = IndexOfMinElem(array2d);
PrintMatrix(array2d);
Console.WriteLine();
int[,] deleteRowColumn = DeleteRowColumn(indexOfMinElem ,array2d);
PrintMatrix(deleteRowColumn);