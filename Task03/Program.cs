// Напишите программу, которая будет выдавать 
// название дня недели по заданному номеру. 
// 3 -> Среда 5 -> Пятница 


Console.Write("Введите номер дня недели: ");
int day = Convert.ToInt32(Console.ReadLine());

if (day > 0 && day < 8)
{
    if (day == 1) Console.Write("Понедельник");
    else if (day == 2) Console.Write("Вторник"); 
    // используем else if для того, чтобы программа не проверяла дальше в случае выполнения условия
    else if (day == 3) Console.Write("Среда");
    else if (day == 4) Console.Write("Четверг");
    else if (day == 5) Console.Write("Пятница");
    else if (day == 6) Console.Write("Суббота");
    else Console.Write("Воскресенье");
}
else Console.Write("Такого дня недели не существует");
