// нарищшите программу, которая принимает на вход три числа и проверяет, может ли существовать треугольник со сторонами такой длины
// Теорема о нерапвенстве треугольника: Каждая из сторон треугольника меньше суммы двух других сторон.

bool CheckTriangle(int first, int second, int third)
{
    return first < second + third 
           && second < first + third 
           && third < second + first;
}

Console.WriteLine("Введите первое число: ");
int firstSide = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int secondSide = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите третее число: ");
int thirdSide = Convert.ToInt32(Console.ReadLine());
bool checkTriangle = CheckTriangle(firstSide, secondSide, thirdSide);
Console.WriteLine(checkTriangle 
               ? "Да, можно постоить треугольник с такими сторонами" 
               : "Нет,  нельзя построить треугольник с такими сторонами")
               ;