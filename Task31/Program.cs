// Задача 31: 
// 1. Задайте массив из 12 элементов, 
// 2. заполненный случайными числами из промежутка [-9, 9]. 
// 3. Найдите сумму отрицательных и положительных элементов массива.



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

int[] GetSumPositiveNegativeElem(int[] array) // чтобы в методе возвращать 
{
    int sumPositive = 0;
    int sumNegative = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0) sumPositive += array[i];
        else sumNegative += array[i];
    }

    //int[] result = {sumPositive, sumNegative}; можно через переменную возвращать
    return new int[]{sumPositive, sumNegative};
}

int[] arr = CreateArrayRndInt(12, -9, 9);
PrintArray(arr);
// [0] - Сумма положительных элементов, [1] - сумма отрицательных элементов
int[] sumPositiveNegativeElem = GetSumPositiveNegativeElem(arr);
Console.WriteLine($"Сумма положительных элементов - {sumPositiveNegativeElem[0]}");
Console.WriteLine($"Сумма отрицательных элементов - {sumPositiveNegativeElem[1]}");
