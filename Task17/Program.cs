﻿// 17. Напишите программу, которая 
//1. принимает на вход (x  и  y)
//2. причем x != 0 и y != 0
//3. выдает номер четверти плоскости, в которой находится эта 
// точка.

Console.WriteLine("Введите координаты точки");
Console.Write("X: ");
int x = Convert.ToInt32(Console.ReadLine());
Console.Write("Y: ");
int y = Convert.ToInt32(Console.ReadLine());

int quarter = Quarter(x, y);
string result = quarter > 0 
        ? $"Указанные координаты соответствуют четверти -> {quarter}"
        : "Введены некорректные координаты";

Console.WriteLine(result);

int Quarter(int xc, int yc)
{
    if(xc > 0 && y > 0) return 1;
    if(xc < 0 && y > 0) return 2;
    if(xc < 0 && y < 0) return 3;
    if(xc > 0 && y < 0) return 4;
    return 0;
}