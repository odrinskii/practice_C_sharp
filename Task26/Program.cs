// Задача 26: Напишите программу, которая 
// 1. принимает на вход число и 
// 2. выдаёт количество цифр в числе.

// 456 -> 3
// 78 -> 2
// 89126 -> 5

int NumbersQuantity(int x)
{
    int count = 0;
    while (x > 0)
    {
        x = x / 10;
        count++;
    }
    
    return count == 0 ? 1 : count; // использование тернарного оператора
}

Console.Write("Введите число: ");
int num = Math.Abs(Convert.ToInt32(Console.ReadLine()));
int result = NumbersQuantity(num);
Console.WriteLine($"Количество цифр в числе {num} равно {result}");
