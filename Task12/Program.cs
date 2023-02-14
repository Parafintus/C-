// 12. Напишите программу, которая будет принимать на
// вход два числа и выводить, является ли первое число
// кратным второму. Если число 1 не кратно числу 2, то
// программа выводит остаток от деления.
// 34, 5 -> не кратно, остаток 4
// 16, 4 -> кратно
Console.WriteLine("Введите первое число");
int firstNumber = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число");
int secondNumber = Convert.ToInt32(Console.ReadLine());


// if (firstNumber % secondNumber != 0)
//     Console.WriteLine($"некратно, остаток {firstNumber % secondNumber}");
// else Console.WriteLine("кратно");
int Remains(int num1, int num2)
{
    return num1 % num2;
}
int remains = Remains(firstNumber, secondNumber);


if (firstNumber % secondNumber != 0)
    Console.WriteLine($"некратно, остаток {remains}");
else Console.WriteLine("кратно");