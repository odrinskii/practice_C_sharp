// Задача 30: Напишите программу, которая
// 1. выводит массив из 8 элементов, заполненный нулями и единицами в случайном порядке.
// [1,0,1,1,0,1,0,0]

void FillArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        //array[i] = new Random().Next(0, 2);
        Random rnd = new Random(); // вариант, который будет работать в проф среде программирования
        array[i] = rnd.Next(0, 2);
    }
}

void PrintArray(int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i == array.Length - 1)
        {
             Console.Write($"{array[i]}]");
             break;
        }
        Console.Write($"{array[i]},");
    }
    Console.WriteLine();
}

int[] arr = new int[8];
FillArray(arr);
Console.WriteLine($"Сгенерированный массив: ");
PrintArray(arr);