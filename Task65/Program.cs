// See https://aka.ms/new-console-template for more information
Console.Write("Введите натуральное число M: ");
int numberM = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите натуральное число N: ");
int numberN = Convert.ToInt32(Console.ReadLine());
SummNumbersBetween(numberM, numberN);


void SummNumbersBetween(int M, int N)
{
    if (M>N)
    {
        SummNumbersBetween(M-1, N);
        Console.Write ($"{M} ");
    }
    if (M<N)
    {
        SummNumbersBetween(M, N-1);
        Console.Write ($"{N} ");
    }
    if (M==N)
    {
        Console.Write ($"{N} ");
    }
}