// Задача 11. 
// Напишите программу, которая 
// 1. выводит случайное трехзначное число и 
// 2. удаляет вторую цифру этого числа. 


int num = new Random().Next(100, 1000);
Console.WriteLine($"Случайное число из диапазона 100 - 999 -> {num}");

int TwoDigits(int num)
{
    int firstDigit = num / 100;
    int thirdDigit = num % 10;
    int result = firstDigit * 10 + thirdDigit;
    return result;
}

int newDigit = TwoDigits(num);
Console.WriteLine(newDigit);