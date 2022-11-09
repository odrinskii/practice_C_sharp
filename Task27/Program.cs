// Задача 27: Напишите программу, которая 
// 1. принимает на вход число и 
// 2. выдаёт сумму цифр в числе.

// 452 -> 11
// 82 -> 10
// 9012 -> 12


int DigitSum(int x)
{
    int digit = 0;
    int lastDigit = 0;
    while (x > 0)
    {
        lastDigit = x % 10;
        digit += lastDigit;
        x = x / 10;
    }
    return digit;
}

Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

int result = 0;
if (num > 0) 
{
    result = DigitSum(num);
    Console.WriteLine($"Сумма цифр в числе равна {result}");
}
else
{
    num = -num;
    result = DigitSum(num);
    Console.WriteLine($"Сумма цифр в числе равна {result}");
} 
