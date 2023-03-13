// Задача 65: Задайте значения M и N. Напишите программу, которая
// выведет все натуральные числа в промежутке от M до N.
// M = 1; N = 5 -> "1, 2, 3, 4, 5"
// M = 4; N = 8 -> "4, 5, 6, 7, 8"


Console.WriteLine("Введите первое число");
int number1 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите второе число");
int number2 = int.Parse(Console.ReadLine());


NaturalNumbers(number1, number2);

void NaturalNumbers(int num1, int num2)
{
    if (num1 == num2 && num1 == 0 || num2 == 0) return;
    else if (num1 > num2)
    {

        Console.Write($"{num1} ");
        NaturalNumbers(num1 - 1, num2);
    }
    else
    {
        NaturalNumbers(num1, num2 - 1);
        Console.Write($"{num2} ");

    }

}



// Console.WriteLine("Введите число M");
// int numberOne = int.Parse(Console.ReadLine());
// Console.WriteLine("Введите число N");
// int numberTwo = int.Parse(Console.ReadLine());
// PrintNumber(numberOne, numberTwo);

// void PrintNumber(int num1, int num2)
// {
//     if (num1 > num2)
//     {
//         Console.Write($"{num1} ");
//         PrintNumber(num1 - 1, num2);
//     }
//     else if (num2 > num1)
//     {
//         PrintNumber(num1, num2 - 1);
//         Console.Write($"{num2} ");
//     }
//     else 
//     {
//         Console.Write($"{num2} ");
//     }
// }