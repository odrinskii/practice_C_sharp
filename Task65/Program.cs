// Задача 65: Задайте значения M и N. Напишите программу, которая
// выведет все натуральные числа в промежутке от M до N.
// M = 1; N = 5 -> "1, 2, 3, 4, 5"
// M = 4; N = 8 -> "4, 6, 7, 8"

void NumbersMtoN(int x, int y)
{
    if (x == y)
    {
        Console.Write($"{x} "); // тут выводим последнее значение, т.к. без этого оно не берется
        return;
    } 
    Console.Write($"{x} ");
    if (x > y) NumbersMtoN(x - 1, y);
    else NumbersMtoN(x + 1, y);
    
}

Console.WriteLine("Введите два числа друг за другом: ");
int m = Convert.ToInt32(Console.ReadLine());
int n = Convert.ToInt32(Console.ReadLine());
NumbersMtoN(m, n);