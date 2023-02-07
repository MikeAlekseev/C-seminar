// Задача 49: Задайте двумерный массив. Найдите элементы, у
// которых оба индекса чётные, и замените эти элементы на их
// квадраты.
int[,] dimensionalMass = CreateMatrixRndInt(4, 4, 0, 10);
PrintMatrix(dimensionalMass);
Console.WriteLine();
ReplaceMatrix(dimensionalMass);
PrintMatrix(dimensionalMass);

void ReplaceMatrix(int[,] inMatrix)
{
    for (int i = 0; i < inMatrix.GetLength(0); i+=2)
    {
        for (int j = 0; j < inMatrix.GetLength(1); j+=2)
            {
                inMatrix[i, j] *= inMatrix[i, j];
            }
    }
}

int[,] CreateMatrixRndInt(int rows, int columns, int min, int max)
{
    int[,] matrix = new int[rows, columns]; // 0, 1
    Random rnd = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(min, max + 1);
        }
    }
    return matrix;
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