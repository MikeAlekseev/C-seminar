// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, 
// сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// -1, -7, 567, 89, 223-> 3

Console.Clear();
Console.Write("Введите размер массива: ");
int number = Convert.ToInt32(Console.ReadLine());
int[] completionUser = CompletionUser(number);
PrintArray(completionUser);
Console.Write(" -> ");
int result = QuantityOfPositiveNumbers(completionUser);
Console.WriteLine(result);

int QuantityOfPositiveNumbers(int[] arr)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > 0) count++;
    }
    return count;
}

int[] CompletionUser(int num)
{
    int[] mass = new int[num];
    int query;
    for (int i = 0; i < num; i++)
    {
        Console.Write($"Введите значение № {i + 1}: ");
        query = Convert.ToInt32(Console.ReadLine());
        mass[i] = query;
    }
    return mass;
}

void PrintArray(int[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1) Console.Write($"{arr[i]}, ");
        else Console.Write($"{arr[i]}");
    }
    Console.Write("]");
}