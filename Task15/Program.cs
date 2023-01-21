// Задача 15: Напишите программу, которая принимает на вход цифру, 
// обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

Console.WriteLine("Введите цифру дня недели: ");
int dayNumber = Convert.ToInt32(Console.ReadLine());

void HappyDay(int dayNumber)
{
    if (dayNumber == 6 || dayNumber == 7)
    {
        Console.WriteLine($"Выходной");
    }
    else if (dayNumber < 1 || dayNumber > 7)
    {
        Console.WriteLine($"Это не день недели");
    }
    else
    {
        Console.WriteLine($"Не выходной");
    }
}
HappyDay(dayNumber);