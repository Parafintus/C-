// Задача 21

// Напишите программу,
// которая принимает на вход координаты двух точек
// и находит расстояние между ними в 3D пространстве.

// A (3,6,8); B (2,1,-7), -> 15.84

// A (7,-5, 0); B (1,-1,9) -> 11.53

Console.WriteLine("Введите координаты первой точки");
Console.Write("X: ");
double x1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Y: ");
double y1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Z: ");
double z1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координаты второй точки");
Console.Write("X: ");
double x2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Y: ");
double y2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Z: ");
double z2 = Convert.ToInt32(Console.ReadLine());



double distance = Distance(x1, y1, z1, x2, y2, z2);
double dRound = Math.Round(distance, 2, MidpointRounding.ToZero);

Console.WriteLine($"Расстояние между заданными точками равно {dRound} ");

double Distance(double xc1, double yc1,double zc1, double xc2, double yc2, double zc2)
{
    return Math.Sqrt(Math.Pow((y2 - y1), 2) +
         Math.Pow((x2 - x1), 2)+Math.Pow((z2 - z1), 2));
}