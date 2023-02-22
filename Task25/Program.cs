// Задача 25:
// Напишите цикл,
// который принимает на вход два числа (A и B) и
// возводит число A в натуральную степень B.

// 3, 5 -> 243 (3⁵)

// 2, 4 -> 16

Console.WriteLine("Введите число, возводимое в степень");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число степени");
int numberB = Convert.ToInt32(Console.ReadLine());
double pow = Pow(numberA, numberB);
if (numberB < 0) Console.WriteLine("Вевведо некорректное значение степени");
else Console.WriteLine($"Число {numberA}, возведенное в степень {numberB} равно {pow}");
double Pow(int numA, int numB)
{
return  Math.Pow(numA, numB);
}