// Задача 56: Задайте прямоугольный двумерный массив. 
// Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и 
// выдаёт номер строки с наименьшей суммой элементов: 1 строка

int[,] matrix = new int[4, 4];
CreateMatrixRndInt(matrix);
PrintMatrix(matrix);
Console.WriteLine();
MinSumInRow(matrix);



void MinSumInRow(int[,] array)
{
    int minRow = 0;
    int minSumRow = 0;
    int sumRow = 0;
    for (int i = 0; i < array.GetLength(1); i++)
    {
        minRow += array[0, i];
    }
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++) sumRow += array[i, j];
        if (sumRow < minRow)
        {
            minRow = sumRow;
            minSumRow = i;
        }
        sumRow = 0;
    }
    Console.Write($"{minSumRow + 1} строка");
}

int[,] CreateMatrixRndInt(int[,] massiv)
{
    for (int i = 0; i < massiv.GetLength(0); i++)
    {
        for (int j = 0; j < massiv.GetLength(1); j++)
        {
            massiv[i, j] = new Random().Next(1, 10);
        }
    }
    return massiv;
}

void PrintMatrix(int[,] massiv)
{
    for (int i = 0; i < massiv.GetLength(0); i++)
    {
        Console.Write("|");
        for (int j = 0; j < massiv.GetLength(1); j++)
        {
            if (j < massiv.GetLength(1) - 1) Console.Write($"{massiv[i, j], 4} | ");
            else Console.Write($"{massiv[i, j], 4} ");
        }
        Console.WriteLine("|");
    }
}