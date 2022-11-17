// Задача 43: Напишите программу, которая 
// 1. найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

double[] FindXY(double a1, double d1, double a2, double d2)
{
    double[] array = new double [2];
    double x = Math.Round(-(d1 - d2) / (a1 - a2), 1);
    double y = Math.Round(a1 * x + d1, 1);
    array[0] = x;
    array[1] = y;
    return array;
}

Console.WriteLine("Введите коэффициенты уравнения первой прямой: ");
double k1 = Convert.ToDouble(Console.ReadLine());
double b1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите коэффициенты уравнения первой прямой: ");
double k2 = Convert.ToDouble(Console.ReadLine());
double b2 = Convert.ToDouble(Console.ReadLine());

if (k1 != k2)
{
    double[] arr = FindXY(k1, b1, k2, b2);

    Console.WriteLine($"Точка пересечения прямых имеет координаты: ({arr[0]}; {arr[1]})");
}
else Console.WriteLine("Прямые параллельны, либо совпадают");