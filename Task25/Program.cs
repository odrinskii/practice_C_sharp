// Задача 25: Напишите цикл, который 
// 1. принимает на вход два числа (A и B) и 
// 2. возводит число A в натуральную степень B.

// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

int DigDgr(int x, int y)
{
    int newDigit = 1;
    for (int i = 1; i <= y; i++)
    {
        newDigit *= x;
    }
    return newDigit;
}

Console.Write("Введите первое число: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int num2 = Convert.ToInt32(Console.ReadLine());

int result;
if (num2 >= 0)
{
    result = DigDgr(num1, num2);
    Console.WriteLine($"Число {num1} в степени {num2} равняется {result}");
}
else Console.WriteLine("Ошибка! Второе число не может быть отрицательным.");

