// Задача 69: Напишите программу, которая на вход принимает два числа A и B, и
// возводит число А в целую степень B с помощью рекурсии.
// A = 3; B = 5 -> 243 (3⁵)
// A = 2; B = 3 -> 8


Console.WriteLine("Введите число, возводимое в степень");
int number = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число степени");
int power = int.Parse(Console.ReadLine());
if (power < 0) Console.WriteLine("Ошибка ввода");
else Console.WriteLine($"{number},{power} => {PowNumber(number, power)} ");

int PowNumber(int num, int pow)
{
    if (pow == 0) return 1;
    else return num * PowNumber(num, pow - 1);
}





// int PowerRecMath(int num, int pow)
// {
//     //return n == 0 ? 1 : PowerRec(a, n - 1) * a;   // тернарный оператор
//     if (pow == 0) return 1;
//     else if (pow % 2 == 0) return PowerRecMath(num * num, pow / 2);
//     else return PowerRecMath(a, n - 1) * a;
// }

// Console.Write("Введите число A: ");
// int numberOne = int.Parse(Console.ReadLine());
// Console.Write("Введите число B: ");
// int numberTwo = int.Parse(Console.ReadLine());
// Console.Write($"Число {numberOne} в степени {numberTwo} = ");
// Console.WriteLine(PowerRecMath(numberOne, numberTwo));