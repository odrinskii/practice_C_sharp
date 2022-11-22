// Задача 52. Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.


int[,] CreateMatrixRndInt(int rows, int columns, int min, int max)
{
    int[,] matrix = new int[rows, columns]; // [0, 1]
    Random rnd = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++) // Get.Length(0) указывает на строки, Get.Length(1) указывает на столбцы и тд. Двумерная конструкция, трехмерная и тд
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(min, max + 1);
        }

    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("|");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j],5} | "); // после запятой ставим длину строки
            else Console.Write($"{matrix[i, j],5}");
        }
        Console.WriteLine(" |");
    }
}

double[] FindAverage(int[,] matrix)
{
    double[] arrayAv = new double[matrix.GetLength(1)];

    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        double sum = 0;
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            sum += matrix[i, j];
        }
        arrayAv[j] = Math.Round(sum / matrix.GetLength(1), 1);
    }
    return arrayAv;
}


void PrintArray(double[] array)
{
    Console.Write("|");
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1) Console.Write($"{array[i],5} | ");
        else Console.Write($"{array[i],5}");
    }
    Console.WriteLine(" |");
}

Console.Write("Введите количество строк: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов: ");
int n = Convert.ToInt32(Console.ReadLine());

if (m > 0 && n > 0)
{
    int[,] array2D = CreateMatrixRndInt(m, n, -100, 100);
    PrintMatrix(array2D);
    double[] averArray = FindAverage(array2D);
    Console.WriteLine("Среднее арифметическое элементов столбцов:");
    PrintArray(averArray);
}
else Console.WriteLine("Ошибка! Для количества строк и столбцов введите целое положительное число.");
