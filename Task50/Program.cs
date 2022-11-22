// Задача 50. Напишите программу, которая 
// 1.на вход принимает позиции элемента в двумерном массиве, и 
// 2. возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 1, 7 -> такого элемента в массиве нет

double[,] CreateMatrixRndDouble(int rows, int columns, double min, double max)
{
    double[,] matrix = new double[rows, columns];
    Random rnd = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = Math.Round(rnd.NextDouble() * (max - min) + min, 1);
        }

    }
    return matrix;
}

void PrintMatrix(double[,] matrix)
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

double FindElement(double[,] matrix, int row, int column)
{
    double element = 0;
    element = matrix[row - 1, column - 1]; // Пользователь задает координаты позиции, поэтому отнимаем 1 для соответсвтия индексу матрицы
    return element;
}

Console.Write("Введите количество строк: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов: ");
int n = Convert.ToInt32(Console.ReadLine());

if (m > 0 && n > 0)
{
    double[,] array2D = CreateMatrixRndDouble(m, n, -100, 100);
    PrintMatrix(array2D);
    Console.Write("Введите номер строки искомой позиции: ");
    int r = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите номер столбца искомой позиции: ");
    int c = Convert.ToInt32(Console.ReadLine());

    if (r <= array2D.GetLength(0) && c <= array2D.GetLength(1))
    {
        double elem = FindElement(array2D, r, c);
        Console.WriteLine($"Элемент с позицией [{r}, {c}] равен {elem}");
    }
    else Console.WriteLine("Такого элемента нет! Координаты позиции не могут выходить за пределы матрицы и могут быть только целым положительным числом.");
}
else Console.WriteLine("Ошибка! Для количества строк и столбцов введите целое положительное число.");

