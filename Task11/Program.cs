// 1. Напишите программу, которая выводит случайное
// трёхзначное число и удаляет вторую цифру этого
// числа.
// 456 -> 46
// 782 -> 72
// 918 -> 98


// int num;
// int firstDigit;
// int thirdDigit;
// int result;
// num = new Random().Next(100, 1000);
// Console.Write(num);
// firstDigit = num / 100;
// thirdDigit = num % 10;
// result = firstDigit * 10 + thirdDigit;
// Console.Write($"-> {result} ");

int number = new Random().Next(100, 1000);
Console.WriteLine($"введите трехзначное число -> {number}");

int res = RemoveSecondDigit(number);

Console.Write($"-> {res} ");

int RemoveSecondDigit(int num)
{
    int num1 = number / 100;
    int num3 = number % 10;
    int result = num1 * 10 + num3;
    return result;
}

