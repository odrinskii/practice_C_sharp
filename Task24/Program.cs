// Задача 24: Напишите программу, которая
// 1. принимает на вход число (А) и 
// 2. выдаёт сумму чисел от 1 до А.

// 7 -> 28
// 4 -> 10
// 8 -> 36

Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

int SumNumbers(int x)
{
    int sum = 1;
    for (int i = 1; i <= x; i++)
    {
        sum += i; // sum = sum + i
    }


    return sum;
}

if (num > 0)
{
int result = SumNumbers(num);
Console.WriteLine($"Сумма чисел от 1 до {num} = {result}");
}
else Console.WriteLine("Ошибка! Число должно быть больше 0");
