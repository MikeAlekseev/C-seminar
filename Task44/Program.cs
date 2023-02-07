// Задача 44: Не используя рекурсию, выведите первые N чисел
// Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
// Если N = 5 -> 0 1 1 2 3
// Если N = 3 -> 0 1 1
// Если N = 7 -> 0 1 1 2 3 5 8

Console.Clear();
Console.Write("Введите число : ");
int number = Convert.ToInt32(Console.ReadLine());

Fibonacci(number);
void Fibonacci (int num)
{
    int first = 0, second = 1;
    Console.Write($"Если N = {number} -> {first} {second} ");
    for (int i = 3; i <= number; i++)
    {
        int newNumber = first + second;
        Console.Write($"{newNumber} ");
        first = second;
        second = newNumber;
    }
}
