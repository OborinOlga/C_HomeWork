// Напишите программу, которая по заданноу номеру четверти, показывает диапазон
// возможных координат в этой черверти (х и y)
string Coordinate (int quar)
{
    if (quar == 1 ) return "Точка может иметь следующие координаты: x>0, y>0";
    if (quar == 2 ) return "Точка может иметь следующие координаты: x>0, y<0";
    if (quar == 3 ) return "Точка может иметь следующие координаты: x<0, y<0";
    if (quar == 4 ) return "Точка может иметь следующие координаты: x<0, y>0";
    return "Введены некорректный данные - номер четверти";
}

Console.WriteLine("Введите номер четверти, в которой расположена точка:");
int quarter = Convert.ToInt32(Console.ReadLine());

string coordinate = Coordinate(quarter);
Console.WriteLine(coordinate);
