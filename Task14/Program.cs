// Напишите программу, которая
// 1. Принимает на вход число и 
// 2. Проверяет кратно ли оно одновременно 7 и 23

int DivOption(int num)
{
    int result;
    if (num % 7 == 0 && num % 23 == 0)
    {
        result = 1;
    }
    else result = -1;
    return result;
}


Console.Write("Введите целое число:");
int number = Convert.ToInt32(Console.ReadLine());
int decision = DivOption(number);
Console.WriteLine(decision == 1 ? "Да" : "Нет");