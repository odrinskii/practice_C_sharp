// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

// Умножение матрицы A на матрицу B имеет смысл только в том случае, 
// когда число столбцов матрицы A равно числу строк матрицы B.

// В результате умножения двух прямоугольных матриц получается матрица, 
// содержащая столько строк, сколько строк в первой матрице,
// и столько столбцов, сколько столбцов во второй матрице.



int[,] CreateMatrixRndInt(int rows, int columns, int min, int max)
{
    int[,] matrix = new int[rows, columns];
    Random rnd = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++)
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

int[,] DivMatrix(int[,] matrix, int[,] matrix2)
{
    int[,] newMatrix = new int[matrix.GetLength(0), matrix2.GetLength(1)];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix2.GetLength(1); j++)
        {
            int elem = 0;
            for (int k = 0; k < matrix.GetLength(1); k++)
            {
                elem += matrix[i, k] * matrix2[k, j]; // реализуем умножение 
            }
            newMatrix[i, j] = elem;
        }
    }
    return newMatrix;
}



Console.Write("Введите количество строк матрицы A: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов матрицы A: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество строк матрицы B: ");
int p = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов матрицы B: ");
int q = Convert.ToInt32(Console.ReadLine());
if (m > 0 && n > 0 && p > 0 && q > 0)
{
    if (n == p)
    {
        int[,] matrixA = CreateMatrixRndInt(m, n, 0, 20);
        int[,] matrixB = CreateMatrixRndInt(p, q, 0, 20);
        PrintMatrix(matrixA);
        Console.WriteLine();
        PrintMatrix(matrixB);
        Console.WriteLine();
        int[,] matrixAB = DivMatrix(matrixA, matrixB);
        Console.WriteLine("Результат умножения матрицы А на матрицу B: ");
        PrintMatrix(matrixAB);
    }
    else Console.WriteLine("Ошибка! Умножение матриц возможно когда число столбцов матрицы A равно числу строк матрицы B.");

}
else Console.WriteLine("Ошибка! Для количества строк и столбцов введите целое положительное число.");