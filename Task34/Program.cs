// Задача 34: 
// Задайте массив 
// 1. заполненный случайными положительными трёхзначными числами. 
// 2. Напишите программу, которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2

int[] CreateArrayRndInt(int size, int min, int max)
{
    int[] array = new int[size];
    Random rnd = new Random();
    for (int i = 0; i < size; i++)
    {
        array[i] = rnd.Next(min, max + 1);
    }
    return array;
}

void PrintArray(int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1) Console.Write($"{array[i]}, ");
        else Console.Write($"{array[i]}");
    }
    Console.WriteLine("]");
}

int FindEvenNum(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0) count++;
    }
    return count;
}


int[] arr = CreateArrayRndInt(10, 100, 999);
PrintArray(arr);
int result = FindEvenNum(arr);
Console.WriteLine($"Количество четных чисел в массиве равно {result}");

// Console.Write("Введите размер массива: ");
// int length = Convert.ToInt32(Console.ReadLine());
// if (length > 0)
// {
//     Console.Write("Введите минимальное значение массива: ");
//     int x = Convert.ToInt32(Console.ReadLine());
//     Console.Write("Введите максимальное значение массива: ");
//     int y = Convert.ToInt32(Console.ReadLine());

//     int[] arr = CreateArrayRndInt(length, x, y);
//     PrintArray(arr);
//     int result = FindEvenNum(arr);
//     Console.WriteLine($"Количество четных чисел в массиве равно {result}");
// }
// else Console.WriteLine("Ошибка! Размер массива не может быть отрицательным или равен нулю");