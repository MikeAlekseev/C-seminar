// Задача 69: Напишите программу, которая на вход принимает два числа А и В, и
// выводит число А в целую степень В с помощью рекурсии.
// А = 3; B = 5 -> 243(3^5)
// A = 2; B = 3 -> 8

Console.WriteLine("Введите первое число: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int num2 = Convert.ToInt32(Console.ReadLine());

int sumNumbers = SumNumbers(num1, num2);
Console.WriteLine($"A в степени B равно {sumNumbers}");

int SumNumbers(int number1, int number2)
{
    if (number2 == 0) return 1;
    else return number1 * SumNumbers(number1, number2 - 1);
}