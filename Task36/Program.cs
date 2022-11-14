// Задача 36: 
// 1. Задайте одномерный массив, заполненный случайными числами. 
// 2. Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19

// [-4, -6, 89, 6] -> 0

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

int OddElemSum(int[] array)
{
    int oddElemSum = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (i % 2 != 0) oddElemSum += array[i];
    }
    return oddElemSum;
}

int[] arr = CreateArrayRndInt(10, -10, 10);
PrintArray(arr);
int result = OddElemSum(arr);
Console.WriteLine($"Сумма элементов, стоящих на нечетных позициях равна {result}");

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
//     int result = OddElemSum(arr);
//     Console.WriteLine($"Сумма элементов, стоящих на нечетных позициях равна {result}");
// }
// else Console.WriteLine("Ошибка! Размер массива не может быть отрицательным или равен нулю");