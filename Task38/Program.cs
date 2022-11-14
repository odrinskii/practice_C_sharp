// Задача 38: 
// 1. Задайте массив вещественных чисел. 
// 2. Найдите разницу между максимальным и минимальным элементами массива.

// [3.5, 7.1, 22.9, 2.3, 78.5] -> 76.2

double[] CreateArrayRndDouble(int size, double min, double max) // генерация случайного массива веществ.чисел
{
    double[] array = new double[size];
    Random rnd = new Random();
    for (int i = 0; i < size; i++)
    {
        array[i] = Math.Round(rnd.NextDouble() * (max - min) + min, 1);
    }
    return array;
}

void PrintArray(double[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1) Console.Write($"{array[i]}, ");
        else Console.Write($"{array[i]}");
    }
    Console.WriteLine("]");
}

double MaxDigit(double[] array)
{
    double max = array[0];
    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] > max) max = array[i];
    }
    return max;
}

double MinDigit(double[] array)
{
    double min = array[0];
    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] < min) min = array[i];
    }
    return min;
}

double[] arr = CreateArrayRndDouble(10, -10, 10);
PrintArray(arr);
double maxElem = MaxDigit(arr);
double minElem = MinDigit(arr);
double maxMinElemDiff = Math.Round(maxElem - minElem, 1);
Console.WriteLine($"Максимальный элемент массива: {maxElem}");
Console.WriteLine($"Минимальный элемент массива: {minElem}");
Console.WriteLine($"Разница максимального и минимального элементов массива равна {maxMinElemDiff}");

// Console.Write("Введите размер массива: ");
// int length = Convert.ToInt32(Console.ReadLine());
// if (length > 0)
// {
//     Console.Write("Введите начальное значение диапазона массива: ");
//     double x = Convert.ToDouble(Console.ReadLine());
//     Console.Write("Введите конечное значение диапазона массива: ");
//     double y = Convert.ToDouble(Console.ReadLine());

//     double[] arr = CreateArrayRndDouble(length, x, y);
//     PrintArray(arr);
//     double maxElem = MaxDigit(arr);
//     double minElem = MinDigit(arr);
//     double maxMinElemDiff = Math.Round(maxElem - minElem, 1);
//     Console.WriteLine($"Максимальный элемент массива: {maxElem}");
//     Console.WriteLine($"Минимальный элемент массива: {minElem}");
//     Console.WriteLine($"Разница максимального и минимального элементов массива равна {maxMinElemDiff}");
// }
// else Console.WriteLine("Ошибка! Размер массива не может быть отрицательным, дробным или равен нулю");