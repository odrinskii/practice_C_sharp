// Задача 55: Задайте двумерный массив. Напишите программу,
// которая заменяет строки на столбцы. В случае, если это
// невозможно, программа должна вывести сообщение для
// пользователя.


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

void ReplaceRowsColumns(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0)-1; i++)
    {
        for (int j = i + 1; j < matrix.GetLength(1); j++)
        {
            // int temp = matrix[i,j];
            // matrix[i,j] = matrix[j,i];
            // matrix[j,i] = temp;
            // это был стандартный способ, еще есть альтернативный метод кортежей. 
            (matrix[i,j], matrix[j,i]) = (matrix[j,i], matrix[i,j]);
        }
    }
}

Console.Write("Введите количество строк: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов: ");
int n = Convert.ToInt32(Console.ReadLine());
if(m>0 && n>0 && m == n)
{
int[,] array2D = CreateMatrixRndInt(m, n, -10, 10);
PrintMatrix(array2D);
Console.WriteLine();
ReplaceRowsColumns(array2D);
PrintMatrix(array2D);
}
else Console.WriteLine("Ошибка! Замена невозможна! Для количества строк и столбцов введите одинаковые целое положительное число.");