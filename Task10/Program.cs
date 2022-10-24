// Задача 10: Напишите программу, 
// 1. которая принимает на вход трёхзначное число и 
// 2. на выходе показывает вторую цифру этого числа. 
// Выполнить с помощью числовых операций (целочисленное деление, остаток от деления).

// 456 -> 5
// 782 -> 8
// 918 -> 1


int FindSecondDigit(int num)
{
    if (num / 100 != 0 && num / 1000 == 0)
    {
        num = (num / 10) % 10;
        return Math.Abs(num);
    }
    else return -1;
}

Console.Write("Введите целое трехзначное число:");
int digit = Convert.ToInt32(Console.ReadLine());
int result = FindSecondDigit(digit);
Console.WriteLine(result == -1? "Ошибка! Введите трехзначное число." : result);


