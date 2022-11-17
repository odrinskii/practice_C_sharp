// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2

// -1, -7, 567, 89, 223-> 3

double[] FillArray(int num)  // выбрал тип double, чтобы программа могла обработать и вещественные числа
{
    double[] array = new double[num];
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"Введите {i + 1} число: ");
        array[i] = Convert.ToDouble(Console.ReadLine());
    }
    return array;
}

void PrintArray(double[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1) Console.Write($"{array[i]}, ");
        else Console.Write($"{array[i]}");
    }
    Console.WriteLine();
}


int MoreThanZero(double[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0) count += 1;
    }
    return count;
}



Console.WriteLine("Сколько чисел планируется ввести?");
double quantity = Convert.ToDouble(Console.ReadLine());
// тип double выбран для возможности провести проверку на ввод вещественного числа, но почему-то пропускает 2,5. При этом 2.5 и прочие вещественные не пропускает
if (quantity > 0 && (quantity * 10) % 10 == 0)
{
    double[] array = FillArray(Convert.ToInt32(quantity));
    Console.Write("Введенные числа: ");
    PrintArray(array);
    int result = MoreThanZero(array);
    Console.WriteLine($"Среди введенных чисел {result} больше нуля.");
}
else Console.WriteLine("Ошибка! Введите целое положительное число.");