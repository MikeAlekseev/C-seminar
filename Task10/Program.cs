// Задача 10: Напишите программу, которая принимает 
// на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// Выполнить с помощью числовых операций (целочисленное деление, остаток от деления).
// 456 -> 5
// 782 -> 8
// 918 -> 1

// Console.WriteLine("Введите трехзначное число: ");
// int number = Convert.ToInt32(Console.ReadLine());

// int secondNumber = SecondNumber(number);
// if(secondNumber == -1)
// {
//     Console.WriteLine($"Некорректное число");
// }
// else
// {
//     Console.WriteLine(secondNumber);
// }
// int SecondNumber(int num)
// {
//     int result = (num > 99 && num < 1000)?num / 10 % 10: -1;
//     return result;
// } 
// РАБОЧЕЕ РЕШЕНИЕ БЕЗ МЕТОДА

Console.WriteLine("Введите трехзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number > 99 && number < 1000)
{
    Console.WriteLine(SecondNumber(number));
}
else
{
    Console.WriteLine($"Некорректное число");
}

int SecondNumber(int num)
{
    return num / 10 % 10;
}