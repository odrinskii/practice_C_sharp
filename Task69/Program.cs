// Задача 69: Напишите программу, которая на вход принимает два числа A и B, и
// возводит число А в целую степень B с помощью рекурсии.
// A = 3; B = 5 -> 243 (3⁵)
// A = 2; B = 3 -> 8

int DivDigit(int a, int b)
{
    if (b == 0) return 1;
    return a * DivDigit(a, b - 1);
}


Console.WriteLine("Введите число, затем степень, в которую возвести:");
int num1 = Convert.ToInt32(Console.ReadLine());
int num2 = Convert.ToInt32(Console.ReadLine());
if (num2 >= 0)
{
    int result = DivDigit(num1, num2);
    Console.WriteLine($"Число {num1} в степени {num2} равно - {result}");
}
else Console.WriteLine("Ошибка! Введите натуральную степень числа");