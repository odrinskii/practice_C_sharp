// Задача 40: Напишите программу, которая 
// 1. принимает на вход три числа и 
// 2. проверяет, может ли существовать треугольник с сторонами такой длины.
// Теорема о неравенстве треугольника: каждая сторона треугольника
// меньше суммы двух других сторон.


bool TriangleCheck(int x, int y, int z)
{
    if(x + y > z && x + z > y && z + y > x) return true;
    else return false;
}

Console.WriteLine("Введите три стороны треугольника.");
Console.Write("Введите первое число: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int b = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите третье число: ");
int c = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Существует ли такой треугольник?");
if(a > 0 & b > 0 & c > 0)
{
bool result = TriangleCheck(a, b, c);
Console.WriteLine(result ? "Да" : "Нет");
}
else Console.WriteLine("Сторона треугольника не может быть отрицательной");