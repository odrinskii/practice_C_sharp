// Напишите программу, которая будет выдавать 
// название дня недели по заданному номеру. 
// 3 -> Среда 5 -> Пятница 


Console.Write("Введите номер дня недели: ");
int day = Convert.ToInt32(Console.ReadLine());

if (day > 0 && day < 8)
{
    if (day == 1) ConsoleWrite("Понедельник");
    else if (day == 2) ConsoleWrite("Вторник");
    else if (day == 3) ConsoleWrite("Среда");
    else if (day == 4) ConsoleWrite("Четверг");
    else if (day == 5) ConsoleWrite("Пятница");
    else if (day == 6) ConsoleWrite("Суббота");
    else ConsoleWrite("Воскресенье");
}
else Console.Write("Такого дня недели не существует");
