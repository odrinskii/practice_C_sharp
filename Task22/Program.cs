// Напишите программу, которая
// 1. принимает на вход число N и 
// 2. выдает таблицу квадратов чисел от 1 до N

void SqrTab(int num)
{
    int count = 1;
    if (num > 0)
    {
        while (count <= num)
        {
            int sqr = count * count;
            Console.WriteLine($"{count, 4}      {sqr, 4}"); // с выравниванием столбцов
            count++;
        }
    }
    //else Console.WriteLine($"Ошибка! Введите пололожительное число");
}

Console.WriteLine("Введите число:");
int n = Convert.ToInt32(Console.ReadLine());
if (n > 0) SqrTab(n);
else Console.WriteLine("Ошибка! Введите пололожительное число");
