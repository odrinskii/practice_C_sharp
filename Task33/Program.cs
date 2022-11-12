// Задача 33: Задайте массив. Напишите программу, которая
// определяет, присутствует ли заданное число в массиве.
// 4; массив [6, 7, 19, 345, 3] -> нет
// 3; массив [6, 7, 19, 345, 3] -> да

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

bool FindDigit(int[] array, int num)
{
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] == num) return true;
    }
    return false;
}

Console.Write("Введите размер массива: ");
int length = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите минимальное значение массива: ");
int x = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите максимальное значение массива: ");
int y = Convert.ToInt32(Console.ReadLine());

int[] arr = CreateArrayRndInt(length, x, y);
PrintArray(arr);
Console.Write("Введите искомое значение: ");
int numberFind = Convert.ToInt32(Console.ReadLine());
bool result = FindDigit(arr, numberFind);

Console.WriteLine(result ? "Да" : "Нет");

