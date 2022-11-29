// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

long Akkerman(long m, long n)
{
    if (m == 0) 
    {
        return n+1;
    }
    else 
    {
        if (n == 0) return Akkerman(m-1,1);
        else return Akkerman(m-1,Akkerman(m,n - 1));
    }    
}

Console.WriteLine("Введите два натуральных числа друг за другом: ");
long a = Convert.ToInt64(Console.ReadLine());
long b = Convert.ToInt64(Console.ReadLine());
if (a >= 0 && b >= 0)
{
    long result = Akkerman(a, b);
    Console.WriteLine($"Результат вывода функции Аккермана равен {result}");
}
else Console.WriteLine("Ошибка! Введите натуральные числа.");