// Задача 58: Задайте две матрицы. Напишите программу, 
// которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

Console.WriteLine("Введите число строк первой матрицы: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число столбцов первой матрицы и строк второй: ");
int b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число столбцов второй матрицы: ");
int c = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите диапазон случайных чисел: от 1 до ");
int range = Convert.ToInt32(Console.ReadLine());

int[,] Martrix = new int[a, b];
CreateMatrixRndInt(Martrix);
Console.WriteLine($"Первая матрица:");
PrintMatrix(Martrix);

int[,] secomdMartrix = new int[b, c];
CreateMatrixRndInt(secomdMartrix);
Console.WriteLine($"Вторая матрица:");
PrintMatrix(secomdMartrix);

int[,] resultMatrix = new int[a,c];

MultiplicationMatrix(Martrix, secomdMartrix, resultMatrix);
Console.WriteLine($"Произведение первой и второй матриц:");
PrintMatrix(resultMatrix);

void MultiplicationMatrix(int[,] Martrix, int[,] secomdMartrix, int[,] resultMatrix)
{
  for (int i = 0; i < resultMatrix.GetLength(0); i++)
  {
    for (int j = 0; j < resultMatrix.GetLength(1); j++)
    {
      int sum = 0;
      for (int k = 0; k < Martrix.GetLength(1); k++)
      {
        sum += Martrix[i,k] * secomdMartrix[k,j];
      }
      resultMatrix[i,j] = sum;
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