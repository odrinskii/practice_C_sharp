﻿// Напишите программу, которая
// 1. Принимает на вход координаты точки X и Y, причём X=!0, Y=!0 и 
// 2. выдаёт номер четверти плоскости, в которой находится точка(1,2,3,4)


Console.WriteLine("Введите координаты точки:");
Console.Write("X:");
int x = Convert.ToInt32(Console.ReadLine());
Console.Write("Y:");
int y = Convert.ToInt32(Console.ReadLine());

int Quarter(int xc, int yc)
{
    if(xc > 0 && yc > 0) return 1;
    if(xc < 0 && yc > 0) return 2;
    if(xc < 0 && yc < 0) return 3;
    if(xc > 0 && yc < 0) return 4;
    return 0;
}

int quarter = Quarter(x, y);
string result = quarter > 0 
                ? $"Указанные координаты соответствуют четверти => {quarter}"
                : "Введены некорректные координаты";

Console.WriteLine(result);
