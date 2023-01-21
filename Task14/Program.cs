// 14. Напишите программу, которая принимает на
// вход число и проверяет, кратно ли оно
// одновременно 7 и 23.
// 14 -> нет
// 46 -> нет
// 161 -> да

// Console.WriteLine("Введите число: ");
// int num1 = Convert.ToInt32(Console.ReadLine());

// if (num1 % 7 == 0 && num1 % 23 == 0)
// {
//     Console.WriteLine($"Кратно");
// }
// else
// {
//     Console.WriteLine($"{num1} Не кратно");
// }

Console.WriteLine("Введите число: ");
int number1 = Convert.ToInt32(Console.ReadLine());

bool mult = Mult(number1);
Console.WriteLine(mult ? "Да" : "Нет");

bool Mult(int num1)
{
    return num1 % 7 == 0 && num1 % 23 == 0;
}