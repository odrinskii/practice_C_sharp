// Задача 42: Напишите программу, которая будет преобразовывать
// десятичное число в двоичное.
// 45 -> 101101
// 3 -> 11
// 2 -> 10

int DecToBin(int x)
{
    int binDigit = 0;
    int d10 = 1; // множитель для добавления цифр в число
    while (x != 0)
    {
        binDigit = binDigit + (x % 2) * d10;
        x = x / 2;
        d10 *= 10;
    }
    return binDigit;
}

Console.Write("Введите число: ");
int a = Convert.ToInt32(Console.ReadLine());

int decToBin = DecToBin(a);
Console.WriteLine($"Число {a} в двоичной системе равно - {decToBin}");
