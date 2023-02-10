// Задача 50. Напишите программу, которая на вход 
// принимает позиции элемента в двумерном массиве, и возвращает 
// значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 1, 7 -> такого элемента в массиве нет

Console.Write("Введите номер строки : ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите номер столбца : ");
int columns = Convert.ToInt32(Console.ReadLine());

int[,] matrix = new int[3, 4];
CreateMatrixRndInt(matrix);
PrintMatrix(matrix);

if (rows < matrix.GetLength(0) && columns < matrix.GetLength(1))
{
    Console.WriteLine(matrix[rows, columns]);
}
else
{
    Console.WriteLine($"{rows}{columns} -> такого элемента нет");
}



void CreateMatrixRndInt(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(1, 10);
        }
    }
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("|");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j],4} | ");
            else Console.Write($"{matrix[i, j],4} ");
        }
        Console.WriteLine("|");
    }
}