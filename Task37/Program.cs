// Задача 37: 
// 1. Найдите произведение пар чисел в одномерном массиве.
// Парой считаем первый и последний элемент, второй и предпоследний
// и т.д. Результат запишите в новом массиве.
// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 36 21


int[] CreateArrayRndInt(int size, int min, int max)  // Альтернативный способ создания метода для генерации массива
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

int[] NewDivArray(int[] array)
{
    int size = array.Length / 2;
    if (array.Length % 2 == 1) size = size + 1;
    int[] newArray = new int[size];

    for (int i = 0; i < size; i++)
    {
        newArray[i] = array[i] * array[array.Length - 1 - i];
    }

    if (array.Length % 2 == 1) newArray[newArray.Length - 1] = array[array.Length / 2];
    return newArray;
}

Console.Write("Введите размер массива: ");
int length = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите минимальное значение массива: ");
int x = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите максимальное значение массива: ");
int y = Convert.ToInt32(Console.ReadLine());

int[] arr = CreateArrayRndInt(length, x, y);
PrintArray(arr);

int[] newArr = NewDivArray(arr);
PrintArray(newArr);

// Альтернативное решение

// int[] CreateProdArray(int[] arr)
// {
//     int len = arr.Length;
//     int even = len % 2;

//     int[] prodArr = new int[len / 2 + even];

//     int i = 0;
//     while (i < len / 2)
//     {
//         prodArr[i] = arr[i] * arr[len - 1 - i];
//         i++;
//     }

//     if (even == 1) prodArr[i] = arr[i];
//     return prodArr;
// }


// int size = 5;
// int min = 0;
// int max = 9;
// int[] array = CreateArray(size, min, max);
// Console.WriteLine("Программа находит произведение пар чисел в одномерном массиве. (Парой считаем первый и последний элемент, второй и предпоследний и т.д.) Результат записывается в новом массиве.");

// int[] prodArray = CreateProdArray(array);
// PrintArray(array);
// PrintArray(prodArray);


// Генератор массива вещественных чисел

// double[] CreateArrayRndDouble(int size, int min, int max)
// {
// double[] array = new double[size];
// Random rnd = new Random();
// for (int i = 0; i < size; i++)
// {
// double num = rnd.NextDouble() * (max - min) + min;
// array[i] = Math.Round(num, 1);
// }
// return array;
// }