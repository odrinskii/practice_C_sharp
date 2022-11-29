// Задача 66: Задайте значения M и N. 
// Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N. 
// Выполнить с помощью рекурсии.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30


int SumNumbersMtoN(int m, int n)
{
    if (m == n) return m;
    if (m < n) return m + SumNumbersMtoN(m + 1, n);
    else return n + SumNumbersMtoN(m - 1, n);
}

Console.WriteLine("Введите два числа друг за другом: ");
int a = Convert.ToInt32(Console.ReadLine());
int b = Convert.ToInt32(Console.ReadLine());
if (a >= 0 && b >= 0)
{
    int result = SumNumbersMtoN(a, b);
    Console.WriteLine($"Сумма элементов от {a} до {b} равна {result}");
}
else Console.WriteLine("Ошибка! Введите натуральные числа.");