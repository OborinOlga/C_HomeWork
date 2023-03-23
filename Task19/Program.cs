//  напините прогграмму, которая принимает на вход координаты двух точек и находит 
// расстояние между ними в 2-хмерном пространстве

Console.WriteLine("Введите координаты первой точки");
Console.Write("х =");
int xCoor1 = Convert.ToInt32(Console.ReadLine());
Console.Write("y =");
int yCoor1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координаты второй точки");
Console.Write("х =");
int xCoor2 = Convert.ToInt32(Console.ReadLine());
Console.Write("y =");
int yCoor2 = Convert.ToInt32(Console.ReadLine());


int quadro = (xCoor1 - xCoor2)*(xCoor1 - xCoor2) + (yCoor1 - yCoor2)*(yCoor1 - yCoor2);
double length = Math.Sqrt(quadro);
double lengthRound = Math.Round(length, 2, MidpointRounding.ToZero);

Console.WriteLine($"Расстояние между двумя точками равно = {lengthRound}");

// 2й способ с использованием методов

double Length(int x1, int y1, int x2, int y2)
{
    return Math.Sqrt((x1 - x2)*(x1 - x2) + (y1 - y2)*(y1 - y2));
}

double length1 = Length(xCoor1, yCoor1,  xCoor2,  yCoor2);
Console.WriteLine(Math.Round(length1, 2, MidpointRounding.ToZero));