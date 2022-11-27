// Задача 63: Задайте значение N. Напишите программу, которая выведет
// все натуральные числа в промежутке от 1 до N.
// N = 5 -> "1, 2, 3, 4, 5"
// N = 6 -> "1, 2, 3, 4, 5, 6"

Console.WriteLine("Введите натуральное число");
int number = Convert.ToInt32(Console.ReadLine());

void NaturalNumbers(int num)
{
    if(num == 0) return;   // как вариант более легкого восприятия можно прописать if(num>0) {}
    NaturalNumbers(num - 1); // хвостовая рекурсия
    Console.Write($"{num} ");  
}

NaturalNumbers(number);