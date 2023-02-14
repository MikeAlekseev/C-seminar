// Задача 54: Задайте двумерный массив. Напишите программу, 
//которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

int[,] matrix = new int[3, 4];
CreateMatrixRndInt(matrix);
PrintMatrix(matrix);
Decreasing(matrix);
Console.WriteLine();
PrintMatrix(matrix);



void Decreasing(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(1) - 1; k++)
            {
                if (array[i, k] < array[i, k + 1])
                {
                    int temp = array[i, k + 1];
                    array[i, k + 1] = array[i, k];
                    array[i, k] = temp;
                }
            }
        }
    }
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
