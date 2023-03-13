// Задача 57: Составить частотный словарь элементов
// двумерного массива. Частотный словарь содержит
// информацию о том, сколько раз встречается элемент
// входных данных.


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
void PrintArray(int[] arr)

{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1) Console.Write($"{arr[i]}, ");
        else Console.Write(arr[i]);
    }
    Console.Write("]");
}

// int[] MatrixToArray(int[,] matrix)
// {
//     int c = 0;
//     int[] array = new int[matrix.GetLength(0) * matrix.GetLength(1)];

//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             array[с] = matrix[i, j];
//             с++;
//         }
//     }
//     return array;
// }
int[] MatrixToArray(int[,] matrix)
{
	int c = 0;
	int[] array = new int[matrix.Length];
	for (int i = 0; i < matrix.GetLength(0); i++)
	{
		for (int j = 0; j < matrix.GetLength(1); j++)
		{
			array[c] = matrix[i, j];
			c += 1;
		}
	}
	return array;
}

void SumElemArray(int[] array)
{
    int count = 1;
    int curentNumber = array[0];
    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] == curentNumber) count++;
        else
        {
            Console.WriteLine($"Число {curentNumber} встречается {count} раз");
            curentNumber = array[i];
            count = 1;
        }
    }
    Console.WriteLine($"Число {curentNumber} встречается {count} раз");
}



int[,] array2d = CreateMatrixRndInt(4, 4, -10, 10);
int[] arr = MatrixToArray(array2d);
PrintMatrix(array2d);
Console.WriteLine();
Array.Sort(arr);
PrintArray(arr);
Console.WriteLine();
SumElemArray(arr);