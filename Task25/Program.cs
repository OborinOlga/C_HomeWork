// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)         2, 4 -> 16

int Degree (int x, int y)
{
    int degrX = x;
    for (int i = 1; i < y; i++)
    {
        degrX = degrX * x;
    }
    return degrX;
}

Console.WriteLine("Введите два числа");
Console.Write("Основание степни А = ");
int numX = Convert.ToInt32(Console.ReadLine());
Console.Write("Степень - Натуральное число В = ");
int numY = Convert.ToInt32(Console.ReadLine());

int degree = Degree(numX, numY);
Console.WriteLine($"Число {numX} возведенное в степень {numY} дает число {degree}");
