// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

Console.Write("Введите целое число: ");
int N = Convert.ToInt32(Console.ReadLine());
if (N < 2) Console.WriteLine("Недопустимое число.");
else
{
    int even = 2;
    int quantity = N / 2;
    Console.WriteLine($"В диапазоне чисел от 1 до {N} находится {quantity} четных числа(сел)");
    Console.Write($"Список четных чисел выглядит следующим образом: ");

    while (even <= N)
    {
        if (even % 2 == 0)
        {
            Console.Write($"{even}"); 
            if (even < N - 1) Console.Write(", ");
            else Console.Write(". \n");
            
        }
        even++;
    }
}
