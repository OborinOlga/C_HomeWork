// Напишите программу, которая принимает на вход координаты точки (Х и Y),
// причём Х и Y не равны нулю и выдает четверть плоскости (1 -4), в которой
// находится эа точка:

// Console.WriteLine("Введите координату точки по оси Х (не равно нулю):");
// int x = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите координату точки по оси Y (не равно нулю):");
// int y = Convert.ToInt32(Console.ReadLine());

// if (x>0 && y>0)
// {
//     Console.WriteLine("Точка расположена в 1 четверти плоскости");
// }
// else if (x>0 && y<0)
// {
//     Console.WriteLine("Точка расположена в 2 четверти плоскости");
// }
// else if (x<0 && y>0)
// {
//     Console.WriteLine("Точка расположена в 4 четверти плоскости");
// }
// else 
// {
//     Console.WriteLine("Точка расположена в 3 четверти плоскости");
// }


int Quarter (int x, int y)
{
    if (x>0 && y>0) return 1;
    if (x>0 && y<0) return 2;
    if (x<0 && y>0) return 4;
    if (x<0 && y<0) return 3;
    return 0;
}

Console.WriteLine("Введите координаты точки");
Console.Write("х =");
int xCoordinate = Convert.ToInt32(Console.ReadLine());
Console.Write("y =");
int yCoordinate = Convert.ToInt32(Console.ReadLine());


int quarter = Quarter(xCoordinate, yCoordinate);
string result = quarter>0
       ? $"Указанные координаты соответствуют {quarter} четверти"
       : "Введены некорректные координаты";
Console.WriteLine(result);