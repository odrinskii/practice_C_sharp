// Напишите программу, которая
// 1. Принимает на вход число и 
// 2. Проверяет кратно ли оно одновременно 7 и 23

// int DivOption(int num)
// {
//     int result;
//     if (num % 7 == 0 && num % 23 == 0)
//     {
//         result = 1;
//     }
//     else result = -1;
//     return result;
// }
bool DivOption(int num)
{
    return num % 7 == 0 && num % 23 == 0;
}


Console.Write("Введите целое число:");
int number = Convert.ToInt32(Console.ReadLine());
bool multpl = DivOption(number);
Console.WriteLine(multpl ? "Да" : "Нет");