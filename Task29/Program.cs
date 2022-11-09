// Задача 29: Напишите программу, которая 
// 1. задаёт массив из 8 элементов и 
// 2. выводит их на экран.

// 1, 2, 5, 7, 19, 6, 1, 33 -> [1, 2, 5, 7, 19, 6, 1, 33]

void FillArray(int[] arr)
{
    Random rnd = new Random();
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.Next(-100, 100);
    }
}

void PrintArray(int[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        if (i == arr.Length - 1)
        {
            Console.Write($"{arr[i]}]");
            break;
        }
        Console.Write($"{arr[i]}, ");
    }
    Console.WriteLine();
}

Console.Write("Задайте размер массива: ");
int num = Convert.ToInt32(Console.ReadLine());
if (num > 0)
{
    int[] array = new int[num];
    FillArray(array);
    Console.Write("Сгенерированный массив: ");
    PrintArray(array);
}    
else Console.WriteLine("Ошибка! Размер массива не может быть равен 0 или отрицательному числу.");
