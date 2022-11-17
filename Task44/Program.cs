﻿// Задача 44: Не используя рекурсию, выведите первые N чисел
// Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
// Если N = 5 -> 0 1 1 2 3
// Если N = 3 -> 0 1 1
// Если N = 7 -> 0 1 1 2 3 5 8

int[] Fibonacci(int num) // решаем зажачу с помощью массива, метод берет на вход число
{
    int[] array = new int[num]; // задаем новый массив
    for (int i = 0; i < num; i++)
    {
        if (i < 2) array[i] = i;
        else array[i] = array[i - 1] + array[i - 2]; // формула фибоначчи
    }
    return array;
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1) Console.Write($"{array[i]} ");
        else Console.Write($"{array[i]}");
    }
    Console.WriteLine();
}


Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int[] arr = Fibonacci(number);
PrintArray(arr);