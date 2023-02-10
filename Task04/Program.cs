Console.WriteLine("Введите первое число");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число");
int number2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите третье число");
int number3 = Convert.ToInt32(Console.ReadLine());
int max = number1;
if(number2 > max){
    max = number2;
}
else
 if(number3 > max){
    max = number3;
}
Console.WriteLine($"{number1}, {number2}, {number3} -> {max}");