// Напишите программу, которая 
// 1. принимает на вход число (N) и 
// 2. выдаёт таблицу кубов чисел от 1 до N.

void TripleTab(int num)
{
    int count = 1;
    if (num > 0)
    {
        while (count <= num)
        {
            int trpl = count * count * count;
            Console.WriteLine($"{count,4}      {trpl,4}"); // с выравниванием столбцов
            count++;
        }
    }
}

Console.WriteLine("Введите целое положительное число:");
int n = Convert.ToInt32(Console.ReadLine());
if (n > 0) TripleTab(n);
else Console.WriteLine("Ошибка! Введите пололожительное число");