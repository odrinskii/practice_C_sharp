// Задача 12 Напишите программу, которая будет
// 1. Принимать на вход два числа и
// 2. Выводить, является ли первое число кратно второму.
// 3. Если число 1 не кратно числу 2, то программа выводит остаток от деления


int Div(int num1, int num2)
{
    return num1 % num2;
}

Console.Write("Введите первое число:");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число:");
int b = Convert.ToInt32(Console.ReadLine());

int rest = Div(a, b);

Console.WriteLine(rest == 0? "Кратно" : $"Не кратно, остаток - {rest}"); 




