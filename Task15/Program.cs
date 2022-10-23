// Задача 15: Напишите программу, которая 
// 1. принимает на вход цифру, обозначающую день недели, и 
// 2. проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет

string WeekendCheck(int num)
{
    if (num == 6 || num == 7) return "Да";
    else return "Нет"; 
}

Console.Write("Введите число от 1 до 7:");
int digit = Convert.ToInt32(Console.ReadLine());
string result = WeekendCheck(digit);
Console.WriteLine(digit >= 1 && digit <= 7? result : "Ошибка! \nВведите число от 1 до 7.");
