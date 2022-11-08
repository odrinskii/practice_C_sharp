// Задача 28: Напишите программу, которая
// 1. принимает на вход число N и 
// 2. выдаёт произведение чисел от 1 до N.

// 4 -> 24
// 5 -> 120


int DivNumbers(int x)
{
    int div = 1;
    for (int i = 1; i <= x; i++)
    {
        div *= i; // div = div * i
    }


    return div;
}

Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
if (num > 0)
{
int result = DivNumbers(num);
Console.WriteLine($"Произведение чисел от 1 до {num} = {result}");
}
else Console.WriteLine("Ошибка! Число должно быть больше 0");
