// Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N. Выполнить с помощью рекурсии.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30
Console.Write("Введите натуральное число M: ");
int numberM = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите натуральное число N: ");
int numberN = Convert.ToInt32(Console.ReadLine());
Console.Write(SummNumbersFromTill(numberM, numberN));

int SummNumbersFromTill(int M, int N)
{
    if (M == N) return N;
    if (M>N) return SummNumbersFromTill(M, N+1) + N;
    else return SummNumbersFromTill(M+1, N) + M;
}
   