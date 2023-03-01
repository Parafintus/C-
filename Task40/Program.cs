// Задача 40: Напишите программу, которая принимает на вход три
// числа и проверяет, может ли существовать треугольник с сторонами
// такой длины.
// Теорема о неравенстве треугольника: каждая сторона треугольника
// меньше суммы двух других сторон.


Console.WriteLine("Введите первое число");
int number1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе число");
int number2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите третье число");
int number3 = Convert.ToInt32(Console.ReadLine());
if (number1 < 1 || number2 < 1 || number3 < 1) Console.WriteLine("Ошибка ввода");


bool Triangle(int num1, int num2, int num3)
{
    return num1 > num2 + num3 || num2 > num1 + num3 || num3 > num1 + num2;

}

bool result = Triangle(number1, number2, number3);
// if (result) Console.WriteLine("Такого треугольника не существует");
// else Console.WriteLine("Такой треугольник существует");

Console.WriteLine(result ? "Такого треугольника не существует"
                            : "Такой треугольник существует");