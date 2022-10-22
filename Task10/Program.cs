﻿// Задача 10: Напишите программу, 
// 1. которая принимает на вход трёхзначное число и 
// 2. на выходе показывает вторую цифру этого числа. 
// Выполнить с помощью числовых операций (целочисленное деление, остаток от деления).

// 456 -> 5
// 782 -> 8
// 918 -> 1


int FindSecondDigit(int num)
{
    if (num > 99 && num < 1000 || num < -99 && num > -1000) 
    {
        num = (num / 10) % 10;
        Console.Write($"Вторым числом является:  {num} \n");
    }
    else Console.WriteLine("Ввод неверен, введите целое трехзначное число");
    return num;
}

Console.Write("Введите целое трехзначное число:");
int digit = Convert.ToInt32(Console.ReadLine());
FindSecondDigit(digit);



