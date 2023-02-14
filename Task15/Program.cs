// // Задача 15:
// // Напишите программу, 
// // которая принимает на вход цифру, обозначающую день недели,
// // и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет

Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());
if (number > 7)
    Console.WriteLine($"{number} -> Ошибка ввода");

else if (Day(number)) Console.WriteLine($"{number} -> Да"); // true
else Console.WriteLine($"{number} -> Нет"); //false

bool Day(int num)
{
    return num == 7 || num == 6;

}