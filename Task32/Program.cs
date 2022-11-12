// Задача 32: Напишите программу замена элементов
// массива: положительные элементы замените на
// соответствующие отрицательные, и наоборот.
// [-4, -8, 8, 2] -> [4, 8, -8, -2]

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
        if(i < array.Length - 1) Console.Write($"{array[i]}, ");
        else Console.Write($"{array[i]}");
    }
    Console.WriteLine("]");
}

void MirrorArray(int[] array) 
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] *= -1; 
    }
}
Console.Write("Введите размер массива: ");
int length = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите минимальное значение массива: ");
int x = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите максимальное значение массива: ");
int y = Convert.ToInt32(Console.ReadLine());

int[] arr = CreateArrayRndInt(length, x, y);
PrintArray(arr);
MirrorArray(arr);
PrintArray(arr);
