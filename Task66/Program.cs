// Задача 66: Задайте значения M и N. Напишите 
// программу, которая найдёт сумму натуральных элементов в 
// промежутке от M до N. Выполнить с помощью рекурсии.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.WriteLine("Введите первое число: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int number2 = Convert.ToInt32(Console.ReadLine());

PrintResult(number1, number2);


void PrintResult(int num1, int num2)
{
    if (num1 < num2) 
    Console.WriteLine($"Сумма равна {SumNumbers(num1, num2)}");
    else Console.WriteLine("Первое число должно быть меньше второго!");
}


int SumNumbers(int numM, int numN)
{
    if(numM == numN + 1) return 0;
    return numM + SumNumbers(numM + 1, numN);
}



