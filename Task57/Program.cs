// Задача 57: Составить частотный словарь элементов
// двумерного массива. Частотный словарь содержит
// информацию о том, сколько раз встречается элемент
// входных данных.
// 25 мин
// Набор данных 
// { 1, 9, 9, 0, 2, 8, 0, 9 } 

// Частотный массив
// 0 встречается 2 раза
// 1 встречается 1 раз
// 2 встречается 1 раз
// 8 встречается 1 раз
// 9 встречается 3 раза
// 1, 2, 3
// 4, 6, 1
// 2, 1, 6
// 1 встречается 3 раза
// 2 встречается 2 раз
// 3 встречается 1 раз
// 4 встречается 1 раз
// 6 встречается 2 раза

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

int[] NewOneMeasureArray(int[,] matrix)
{
    int[] newArray = new int[matrix.Length];
    int a = 0;
    while (a < newArray.Length)
    {
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                newArray[a] = matrix[i, j];
                a++;
            }
        }
    }
    return newArray;
}

void Dictionary(int[] array) // метод считает кол-во повторяющихся элементов и выводит их в строку
{
    int n = array[0];
    int count = 1;
    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] == n) count++;
        else
        {
            Console.WriteLine($"Число {n} встречается {count} раз.");
            n = array[i];
            count = 1;
        }
    }
    Console.WriteLine($"Число {n} встречается {count} раз.");
}

Console.Write("Введите количество строк: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов: ");
int n = Convert.ToInt32(Console.ReadLine());

int[,] array2D = CreateMatrixRndInt(m, n, -10, 10);
PrintMatrix(array2D);
Console.WriteLine();
int[] array1D = NewOneMeasureArray(array2D);
PrintArray(array1D);
Console.WriteLine();
Array.Sort(array1D);
PrintArray(array1D);
Console.WriteLine();
Dictionary(array1D);

