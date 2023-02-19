// Задача 18: Напишите программу, которая по
// заданному номеру четверти, показывает диапазон
// возможных координат точек в этой четверти (x и y).


Console.WriteLine("Введите номер четверти");
string number = Console.ReadLine();
string quarter = Quarter(number);    //  условие ? значение : значение


Console.WriteLine(quarter == "0" ? "Некорретный ввод данных"
                : $"диапазон возможных координат точек в этой четверти {quarter}");

string Quarter(string num)
{
    if (num == "1") return "x > 0,  y > 0";
    if (num == "2") return "x < 0,  y > 0";
    if (num == "3") return "x < 0,  y < 0";
    if (num == "4") return "x > 0,  y < 0";
    return "0";
}