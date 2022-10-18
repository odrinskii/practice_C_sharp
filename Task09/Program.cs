// // Задача 9
// Напишите программу, которая 
// 1. выводит случайное число из отрезка [10, 99]
// 2. и показывает наибольшую цифру числа

int num = new Random().Next(10, 100);
Console.WriteLine($"Случайное число из диапазона 10 - 99 -> {num}");

// int firstDigit = num / 10;
// int secondDigit = num % 10;

// if (firstDigit > secondDigit) Console.WriteLine($"Наибольшая цифра числа - {firstDigit}");
// else Console.WriteLine($"Наибольшая цифра числа - {secondDigit}");

// int result = firstDigit > secondDigit ? firstDigit : secondDigit;
// Console.WriteLine($"Наибольшая цифра числа - {result}");
// //тернарный оператор Заменяет простейшее ветвление для присваивания значения переменной

// Console.Write($"Наибольшая цифра числа {num} - ");
// Console.Write(firstDigit > secondDigit ? firstDigit : secondDigit);
// Console.Write("\n");

// int max = Math.Max(firstDigit, secondDigit);
// Console.WriteLine($"Наибольшая цифра числа {num} - {max}");

int MaxDigit(int number)
{
    int firstDigit = number / 10;
    int secondDigit = number % 10;
    int result = firstDigit > secondDigit ? firstDigit : secondDigit;
    return result;
}

int maxDigit = MaxDigit(num);
Console.WriteLine($"Наибольшая цифра числа - {maxDigit}");
