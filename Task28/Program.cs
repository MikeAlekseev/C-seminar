// Задача 28: Напишите программу, которая
// принимает на вход число N и выдаёт
// произведение чисел от 1 до N.
// 4 -> 24
// 5 -> 120

// Console.Write("Введите целое положительное число: ");
// int number = Convert.ToInt32(Console.ReadLine());

// int factorial = Factorial(number);
// if(int.TryParse(Console.ReadLine(), out number))
// {
//     if (number > 0)
//         Console.WriteLine($"Факториал числа {number} = {Factorial(number)}");
//     else
//         Console.WriteLine($"Некорректное число");
// }
// else
// Console.WriteLine($"Введено некорректное число");

// int Factorial(int num)
// {
//         int productNum = 1;
//         for (int i = 1; i < num; i++)
//         {
//             productNum = productNum * i;
//         }
//         return productNum;
// }

// int Factorial(int num)
// {
//     int productnum = 1;
//     for (int i = 1; i <= num; i++)
//     {
//         checked
//         {
//         productnum = productnum * i;
//         }
//     }
//     return productnum;
// }

// Console.Write("Введите целое число: ");
// int number;
// if (int.TryParse(Console.ReadLine(), out number))
// {
//     if (number > 0)
//         Console.WriteLine($"Факториал числа {number} = {Factorial(number)}");
//     else
//         Console.WriteLine("Введено некорректное значение. Введите натуральное число.");
// }
// else
//     Console.WriteLine("Введено некорректное значение. Введите целое число");

int Factorial(int num)
{
    int productnum = 1;
    for (int i = 1; i <= num; i++)
    {
        productnum = productnum * i;
    }
    return productnum;
}

Console.Write("Введите целое число: ");
int number;
if (int.TryParse(Console.ReadLine(), out number))
{
    if (number > 0)
        Console.WriteLine($"Факториал числа {number} = {Factorial(number)}");
    else
        Console.WriteLine("Введено некорректное значение. Введите натуральное число.");
}
else
    Console.WriteLine("Введено некорректное значение. Введите целое число");