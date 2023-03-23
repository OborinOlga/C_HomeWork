// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
bool Holliday (int dday)
{
    return dday == 6 || dday == 7;
}

Console.WriteLine("Введите цифру, обозначающую день недели");
int day = Convert.ToInt32(Console.ReadLine());

if (day < 8 && day > 0)
{
    bool holliday = Holliday(day);
    Console.WriteLine(holliday ? "Это день - выходной" : "Нет, еще нужно идти на работу");
}
else
{
    Console.WriteLine("Неверное число дня недели");
}

