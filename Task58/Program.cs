// Задача 58:
// Задайте две матрицы.
// Напишите программу,
// которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

Console.WriteLine("Укажите количество строк первой матрицы");
int row1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Укажите количество столбцов первой матрицы");
int column1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Укажите количество строк второй матрицы");
int column2 = Convert.ToInt32(Console.ReadLine());

int[,] resultMatrix = new int[row1,column2];
int[,] firstArray2d = CreateMatrixRndInt(row1, column1, -10, 10);
int[,] secondArray2d = CreateMatrixRndInt(column1, column2, -10, 10);

PrintMatrix(firstArray2d);
Console.WriteLine();
PrintMatrix(secondArray2d);
Console.WriteLine();

MultiplyMatrix(firstArray2d, secondArray2d, resultMatrix);
Console.WriteLine($"Произведение первой и второй матриц:");
PrintMatrix(resultMatrix);

void MultiplyMatrix(int[,] firstMartrix, int[,] secondMartrix, int[,] resultMatrix)
{
  for (int i = 0; i < resultMatrix.GetLength(0); i++)
  {
    for (int j = 0; j < resultMatrix.GetLength(1); j++)
    {
      int sum = 0;
      for (int k = 0; k < firstMartrix.GetLength(1); k++)
      {
        sum += firstMartrix[i,k] * secondMartrix[k,j];
      }
      resultMatrix[i,j] = sum;
    }
  }
}

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


