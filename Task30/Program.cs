// Задача 30: Напишите программу, которая
// выводит массив из 8 элементов, заполненный
// нулями и единицами в случайном порядке.
// [1,0,1,1,0,1,0,0]

// int[] array = new int[8]; // 0, 1, 2, 3, 4, 5, 6, 7
// array[0] = new Random().Next(10, 100);

// void MassiveFiller(int[] col)
// {
//     for (int i = 0; i < col.Length; i++)
//         col[i] = new Random().Next(0, 2);
// }

// void MassiveConclusion(int[] col)
// { 
//     Console.Write("Получившийся массив: ");
//     for (int i = 0; i < col.Length; i++)
//     {
//         Console.Write($"   {col[i]}");   
//     }
// }

// int[] array = new int[8];
// MassiveFiller(array);
// MassiveConclusion(array);

int[] arr = CreateArray(8);
PrintArray(arr);


int[] CreateArray(int size)
{
    int[] array = new int[size];
    Random rnd = new Random();
    for (int i = 0; i < size; i++)
    {
        array[i] = rnd.Next(0, 2);
    }
    return array;
}


void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
}