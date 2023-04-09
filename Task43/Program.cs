// Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, 
// y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

void PointIntersection(double K1, double B1, double K2, double B2)
{
    if (K1 == K2)
    {
        if (B1 == B2) Console.WriteLine("Точка перечечения линий отсутствует, так как они совпадают");
        else Console.WriteLine("Точка перечечения линий отсутствует, так как они параллельны");
    }
    else
    {
        double x = Math.Round((B2 - B1)/(K1 - K2), 2);
        double y = Math.Round(K1 * x + B1, 2);
        Console.WriteLine($"Точка пересечения указанных линий [{x},  {y}]");
    }
}

Console.WriteLine("Введите значение k1  из уравнения линии y = k1 * x + b1 : ");
double k1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите значение b1  из уравнения линии y = k1 * x + b1 : ");
double b1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите значение k2  из уравнения линии y = k2 * x + b2 : ");
double k2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите значение b2  из уравнения линии y = k2 * x + b2 : ");
double b2 = Convert.ToInt32(Console.ReadLine());
PointIntersection(k1, b1, k2, b2);



