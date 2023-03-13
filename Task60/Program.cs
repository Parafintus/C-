// Задача 60.
// Сформируйте трёхмерный массив из неповторяющихся двузначных чисел.
// Напишите программу,
// которая будет построчно выводить массив,
// добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// Результат:
// 66(0,0,0) 27(0,0,1) 25(0,1,0) 90(0,1,1)
// 34(1,0,0) 26(1,0,1) 41(1,1,0) 55(1,1,1)



Console.WriteLine("Укажите количество строк в массиве");
int xc = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Укажите количество столбцов в массиве");
int yc = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Укажите глубину  массива");
int zc = Convert.ToInt32(Console.ReadLine());


;
int[,,] array3d = new int[xc, yc, zc];
void Create3DMatrixRndInt(int[,,] array3D)
{
  int[] temp = new int[array3D.GetLength(0) * array3D.GetLength(1) * array3D.GetLength(2)];
  int  number;
  for (int i = 0; i < temp.GetLength(0); i++)
  {
    temp[i] = new Random().Next(10, 100);
    number = temp[i];
    if (i >= 1)
    {
      for (int j = 0; j < i; j++)
      {
        while (temp[i] == temp[j])
        {
          temp[i] = new Random().Next(10, 100);
          j = 0;
          number = temp[i];
        }
          number = temp[i];
      }
    }
  }
  int count = 0; 
  for (int x = 0; x < array3D.GetLength(0); x++)
  {
    for (int y = 0; y < array3D.GetLength(1); y++)
    {
      for (int z = 0; z < array3D.GetLength(2); z++)
      {
        array3D[x, y, z] = temp[count];
        count++;
      }
    }
  }
}



void Print3DMatrix(int[,,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("|");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int k = 0; k < matrix.GetLength(2); k++)
            {
                if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j, k],3}({i},{j},{k}), ");
                else Console.Write($"{matrix[i, j, k],3}({i},{j},{k})");
            }
        }
        Console.WriteLine("|");
    }
}



Create3DMatrixRndInt(array3d);
Print3DMatrix(array3d);