// Задача 43:
// Напишите программу,
// которая найдёт точку пересечения двух прямых,
// заданных уравнениями
// y = k1 * x + b1,
// y = k2 * x + b2;
// значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

Console.WriteLine("Введите коэффициент k1");
double kc1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите константу b1");
double bc1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите коэффициент k2");
double kc2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите константу b2");
double bc2 = Convert.ToInt32(Console.ReadLine());

if (kc1 == kc2 && bc1 == bc2) Console.WriteLine("Указаны одинаковые линии");
else if (kc1 == kc2) Console.WriteLine("Линии паралельны");
else
{

    double[] FindCoords(double b1, double k1, double b2, double k2)
    {
        double[] coord = new double[2];
        coord[0] = (b2 - b1) / (k1 - k2);
        coord[1] = k1 * coord[0] + b1;
        return coord;
    }

    void PrintArray(double[] coord)
    {
        Console.Write("[");
        for (int i = 0; i < coord.Length; i++)
        {
            if (i < coord.Length - 1) Console.Write($"{coord[i]}, ");
            else Console.Write(coord[i]);
        }
        Console.Write("]");
    }
    double[] findCoords = FindCoords(bc1, kc1, bc2, kc2);
    Console.WriteLine($"Точка пересечения двух прямых, заданных уравнениями находится в: ");
    PrintArray(findCoords);

}