// Задача 65: Задайте значения M и N. Напишите программу, которая
// выведет все натуральные числа в промежутке M и N.
// M = 1; N = 5 -> "1, 2, 3, 4, 5"
// M = 4; N = 8 -> "4, 5, 6, 7, 8"

Console.WriteLine("Введите первое число: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int number2 = Convert.ToInt32(Console.ReadLine());

NaturalNumber(number1, number2);

void NaturalNumber(int numM, int numN)
{
    if(numM < numN)
    {
    Console.Write($"{numM} ");
    NaturalNumber(numM + 1, numN);
    }
    else if (numM > numN)
    {
        Console.Write($"{numM} ");
    NaturalNumber(numM - 1, numN);
    }
    else Console.WriteLine(numN);
} 