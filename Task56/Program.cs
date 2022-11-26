// Задача 56: Задайте прямоугольный двумерный массив. 
// Напишите программу, которая будет находить строку с наименьшей суммой элементов.

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

int[] FindRowSum(int[,] matrix)
{
    int[] arrayRowSum = new int[matrix.GetLength(0)];

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            sum += matrix[i, j];
        }
        arrayRowSum[i] = sum;
    }
    return arrayRowSum;
}

void PrintArray(int[] array)
{
    Console.Write("|");
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1) Console.Write($"{array[i],5} | ");
        else Console.Write($"{array[i],5}");
    }
    Console.WriteLine(" |");
}

int MinSumRow(int[] array)
{
    int minSumRowIndex = 0;
    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] < array[minSumRowIndex]) minSumRowIndex = i;
    }
    return minSumRowIndex;
}


Console.Write("Введите количество строк: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов: ");
int n = Convert.ToInt32(Console.ReadLine());
if (m > 0 && n > 0)
{
    int[,] array2D = CreateMatrixRndInt(m, n, 0, 20);
    PrintMatrix(array2D);
    Console.WriteLine();
    int[] array1D = FindRowSum(array2D);
    PrintArray(array1D);
    Console.WriteLine();
    int result = MinSumRow(array1D);
    Console.WriteLine($"{result + 1}-я строка с наименьшей суммой");


}
else Console.WriteLine("Ошибка! Для количества строк и столбцов введите целое положительное число.");