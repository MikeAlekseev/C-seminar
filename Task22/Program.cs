// 1 1
// 2 4
// 3 9
// 4 16
// 6 36
// Задача 22: Напишите программу, которая
// принимает на вход число (N) и выдаёт таблицу
// квадратов чисел от 1 до N.
// 5 -> 1, 4, 9, 16, 25.
// 2 -> 1,4



// Console.WriteLine("Введите число ");
// int number = Convert.ToInt32(Console.ReadLine());

// void Square(int num)
// {
//     for (int i = 1; i <= num; i++)
//     {
//         Console.WriteLine($"{i} -> {i * i}");
//     }
// }
// Square(number);



Console.Write("Введите число: ");
int x = Convert.ToInt32(Console.ReadLine());

if (x > 1)
    SquareTable(x);
else
{
    Console.WriteLine("Введено некорректное значение");
}
void SquareTable(int x)
{
    int count = 1;

    while (count <= x)
    {
        Console.WriteLine($"|{count} | {Math.Pow(count, 2)}|");
        count++;
    }
}
