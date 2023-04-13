// Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29
Console.Write("Введите натуральное число n для функции Аккермана: ");
int numberN = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите натуральное число m для функции Аккермана: ");
int numberM = Convert.ToInt32(Console.ReadLine());
Console.Write(Akkereman(numberN, numberM));

int Akkereman(int n, int m)
{
    while (n != 0)
    {
        if (m == 0) m = 1;
        else m = checked(Akkereman(n, m - 1));
        n = n - 1;
    }
    return m + 1;
}