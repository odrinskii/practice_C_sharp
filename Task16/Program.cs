// Напишите программу, которая 
// 1. Принимает на вход два числа
// 2. Проверяет является ли одно число квадратом другого


bool MultCheck(int a, int b)
{
    return a * a == b || b * b == a;
}

Console.Write("Введите первое число:");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число:");
int num2 = Convert.ToInt32(Console.ReadLine());

bool square = MultCheck(num1, num2);
Console.WriteLine(square ? "Да" : "Нет");
