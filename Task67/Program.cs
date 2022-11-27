// Задача 67: Напишите программу, которая будет принимать на вход число и
// возвращать сумму его цифр.
// 453 -> 12
// 45 -> 9

int DigitSum(int num)
{
    if(num == 0) return 0;
    return num % 10 + DigitSum(num / 10);
}


Console.WriteLine("Введите натуральное число");
int number = Convert.ToInt32(Console.ReadLine());

int result = DigitSum(number);
Console.WriteLine($"Сумма цифр числа - {result}");