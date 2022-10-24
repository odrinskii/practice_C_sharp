// Задача 13: Напишите программу, 
// 1. которая выводит третью цифру заданного числа 
// 2. или сообщает, что третьей цифры нет. 
// Выполнить с помощью числовых операций (целочисленное деление, остаток от деления).
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

int GetNeededNumber(int num)
{
    if (num / 100 != 0)
    {
        while (num / 1000 != 0)
        {
            num = num / 10;
        }
        num = num % 10;
        return Math.Abs(num);
    }
    else return -1;
}

Console.Write("Введите целое число:");
int digit = Convert.ToInt32(Console.ReadLine());
int result = GetNeededNumber(digit);
Console.WriteLine(result == -1 ? "Третьей цифры нет" : result);
