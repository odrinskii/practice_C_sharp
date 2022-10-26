// напишите программу, которая по заданному номеру четверти
// 1. показывает диапазон возможных координат точек в этой четверти(x и y)


Console.WriteLine("Введите номер четверти:");
int num = Convert.ToInt32(Console.ReadLine());

string Quarter(int number)
{
    if(number == 1) return "Координаты в диапазоне x > 0 и y > 0";
    if(number == 2) return "Координаты в диапазоне x < 0 и y > 0";
    if(number == 3)return "Координаты в диапазоне x < 0 и y < 0";
    if(number == 4) return "Координаты в диапазоне x > 0 и y < 0";
    return "Неверный номер четверти";
}

string quarter = Quarter(num);
Console.WriteLine(quarter); 
