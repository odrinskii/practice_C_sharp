﻿// 5. Напишите программу, которая на вход принимает одно число (N), 
// а на выходе показывает все целые числа в промежутке от -N до N. 
// 4 -> "-4, -3, -2, -1, 0, 1, 2, 3, 4" 2 -> " -2, -1, 0, 1, 2" 

Console.WriteLine("Введите число:"); 
int a = Convert.ToInt32(Console.ReadLine()); 
if (a < 1) Console.WriteLine("Недопустимое число"); 
else 
{ 
    int count = -a; 
    while (count <= a) 
    { 
        Console.Write($"{count} "); 
        count = count + 1; 
    } 
} 













    // 7. Напишите программу, которая принимает на вход // трёхзначное число и на выходе показывает последнюю цифру // этого числа. // 456 -> 6 // 782 -> 2 // 918 -> 8 Console.WriteLine("Введите число:"); int a = Convert.ToInt32(Console.ReadLine()); Console.WriteLine(a % 10); 