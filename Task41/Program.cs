// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2

// -1, -7, 567, 89, 223-> 3

int[] FillArray(int num)
{
    int[] array = new int[num];
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"Введите {i+1} элемент: ");
        array[i] = Convert.ToInt32(Console.ReadLine());
    }
    return array;
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1) Console.Write($"{array[i]}, ");
        else Console.Write($"{array[i]}");
    }
    Console.WriteLine();
}


int MoreThanZero(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0) count += 1; 
    }
    return count;
}

Console.WriteLine("Сколько чисел планируется ввести?");
int quantity = Convert.ToInt32(Console.ReadLine());

int[] array = FillArray(quantity);
Console.Write("Введенные числа: ");
PrintArray(array);
int result = MoreThanZero(array);
Console.WriteLine($"Среди введенных чисел {result} больше нуля.");
