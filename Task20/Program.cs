// Задача 20: Напишите программу, которая
// принимает на вход координаты двух точек и
// находит расстояние между ними в 2D
// пространстве.
// A (3,6); B (2,1) -> 5,09
// A (7,-5); B (1,-1) -> 7,21

// Math.Sqrt(5);
// Math.Pow(2, 10);
// double d = 5.099987; 
// double dRound = Math.Round(d, 2, MidpointRounding.ToZero);
// Console.WriteLine(dRound);


// double pow2 = Math.Pow((y2 - y1), 2);
// double pow1 = Math.Pow((x2 - x1), 2);
// double sqrt = Math.Sqrt(pow1 + pow2);/

Console.WriteLine("Введите координаты первой точки");
Console.Write("X: ");
double x1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Y: ");
double y1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координаты второй точки");
Console.Write("X: ");
double x2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Y: ");

double y2 = Convert.ToInt32(Console.ReadLine());
double distance = Distance(x1, y1, x2, y2);
double dRound = Math.Round(distance, 2, MidpointRounding.ToZero);

Console.WriteLine($"Расстояние между заданными точками равно {dRound} ");

double Distance(double xc1, double yc1, double xc2, double yc2)
{
    return Math.Sqrt(Math.Pow((y2 - y1), 2) +
         Math.Pow((x2 - x1), 2));
}



