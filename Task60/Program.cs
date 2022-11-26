// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, 
// которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Например, задан массив размером 2 x 2 x 2.
// Результат:
// 66(0,0,0) 27(0,0,1) 25(0,1,0) 90(0,1,1)
// 34(1,0,0) 26(1,0,1) 41(1,1,0) 55(1,1,1)

int[] UniqueArray(int len, int min, int max)
{
    int[] array = new int[len];
    for (int i = 0; i < array.Length; i++)
    {
        Random rnd = new Random();
        array[i] = rnd.Next(min, max + 1);              // Генерируем одномерный массив, заполненный случайными неповторяющимися числами. 
        for (int j = 0; j < i; j++)
        {
            if (array[i] == array[j])
            {
                array[i] = rnd.Next(min, max + 1);
            }
        }
    }
    return array;
}

void PrintArray(int[] array)
{
    Console.Write("|");
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1) Console.Write($"{array[i],2} | ");
        else Console.Write($"{array[i],2}");
    }
    Console.WriteLine(" |");
}

int[,,] CreateMatrixRndInt(int rows, int columns, int depth, int min, int max, int[] array)
{
    int[,,] matrix = new int[rows, columns, depth];
    Random rnd = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++) 
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int k = 0; k < matrix.GetLength(2); k++)
            {
                matrix[i, j, k] = array[rnd.Next(0, array.Length - 1)];
            }
        }
    }
    return matrix;
}

void Print3DMatrix(int[,,] matrix3D)
{
    for (int i = 0; i < matrix3D.GetLength(0); i++)
    {
        for (int j = 0; j < matrix3D.GetLength(1); j++)
        {
            for (int k = 0; k < matrix3D.GetLength(2); k++)
            {
                Console.Write($"{matrix3D[i, j, k]}({i},{j},{k}) ");
            }
        }
        Console.WriteLine();
    }
}

Console.Write("Введите ось X: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите ось Y: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите ось Z: ");
int z = Convert.ToInt32(Console.ReadLine());
if (m > 0 && n > 0 && z > 0)
{
    int[] array1D = UniqueArray(89, 10, 99);
    PrintArray(array1D);
    int[,,] array3D = CreateMatrixRndInt(m, n, z, 10, 99, array1D);
    Console.WriteLine();
    Print3DMatrix(array3D);
    
}
else Console.WriteLine("Ошибка! Введите целое положительное число для присвоения значений для осей массива.");