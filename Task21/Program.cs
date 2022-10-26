// Напишите программу, которая 
// 1. принимает на вход координаты двух точек и 
// 2. находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

double Distance(int a1, int b1, int c1, int a2, int b2, int c2)
{
    int dist1 = (a2 - a1)*(a2 - a1);
    int dist2 = (b2 - b1)*(b2 - b1);
    int dist3 = (c2 - c1)*(c2 - c1);
    double dist = dist1 + dist2 + dist3;
    return Math.Sqrt(dist);
}

Console.WriteLine("Введите координаты точки A:");
Console.Write("X1: ");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Y1: ");
int y1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Z1: ");
int z1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координаты точки B:");
Console.Write("X2: ");
int x2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Y2: ");
int y2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Z2: ");
int z2 = Convert.ToInt32(Console.ReadLine());

double distance = Distance(x1, y1, z1, x2, y2, z2);
Console.WriteLine($"Расстояние между точками равно: {Math.Round(distance, 2, MidpointRounding.ToZero)}");