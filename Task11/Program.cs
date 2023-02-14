// 11. Напишите программу, которая выводит случайное
// трёхзначное число и удаляет вторую цифру этого
// числа.
// 456 -> 46
// 782 -> 72
// 918 -> 98


int number = new Random().Next(100, 1000);
Console.WriteLine($"Случайное число из отрезка 100 - 999 =>  {number}");

// int firstDigit = number / 100;
// int ThirdDigit = number % 10;
// int sum = firstDigit * 10 + ThirdDigit;

//Console.WriteLine(sum);

int RemoveSecondDigit(int num) // num = number
{
    int firstDigit = num / 100;
    int thirdDigit = num % 10;
    int sum = firstDigit * 10 + thirdDigit;
    return sum;
    
}

int removeSecondDigit = RemoveSecondDigit(number);
Console.WriteLine($"Полученное число от {number} -> {removeSecondDigit}");