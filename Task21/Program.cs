// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

double Length(int x1, int y1, int z1,int x2, int y2, int z2)
{
    return Math.Sqrt((x1 - x2)*(x1 - x2) + (y1 - y2)*(y1 - y2) + (z1 - z2)*(z1 - z2));
}

Console.WriteLine("Введите координаты первой точки");
Console.Write("хa =");
int xa = Convert.ToInt32(Console.ReadLine());
Console.Write("ya =");
int ya = Convert.ToInt32(Console.ReadLine());
Console.Write("za =");
int za = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координаты второй точки");
Console.Write("хb =");
int xb = Convert.ToInt32(Console.ReadLine());
Console.Write("yb =");
int yb = Convert.ToInt32(Console.ReadLine());
Console.Write("zb =");
int zb = Convert.ToInt32(Console.ReadLine());

double length = Length(xa, ya,  za, xb,  yb, zb);
Console.WriteLine(Math.Round(length, 2, MidpointRounding.ToZero));