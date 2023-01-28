// Задача 27: Напишите программу, которая принимает на 
// вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.Write("Введите целое положительное число: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number > 0)
{
        Console.WriteLine($"Сумма цифр числа {number} = {SumNumbers(number)}");
}
else
    Console.WriteLine("Введено некорректное значение.");

int SumNumbers(int num)
{
    int sum = 0;
    while (num > 0 )
    {
        sum += num % 10;
        num /= 10;
    }
    return sum;
}
