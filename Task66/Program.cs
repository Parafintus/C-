// Задача 66:
// Задайте значения M и N.
// Напишите программу,
// которая найдёт сумму натуральных элементов в промежутке от M до N.
// Выполнить с помощью рекурсии.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.WriteLine("Введите число M");
int numberM = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число N");
int numberN = int.Parse(Console.ReadLine());

int NaturalNumbersIfM(int numm, int numn)
{
    if (numm == numn)
        return numm;
    return numm + NaturalNumbersIfM(numm -1, numn);
  
}
int NaturalNumbersIfN(int numm, int numn)
{
    if (numm == numn)
        return numn;
    return numn + NaturalNumbersIfN(numm, numn-1);
  
}
if(numberM > numberN) Console.WriteLine($"{NaturalNumbersIfM(numberM, numberN)}");
else if(numberM < numberN) Console.WriteLine($"{NaturalNumbersIfN(numberM, numberN)}");
else Console.WriteLine("Числа равны");
