﻿// Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
// M = 1; N = 5 -> "1, 2, 3, 4, 5"
// M = 4; N = 8 -> "4, 5, 6, 7, 8"
Console.Write("Введите натуральное число M: ");
int numberM = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите натуральное число N: ");
int numberN = Convert.ToInt32(Console.ReadLine());
NumbersFromTillUp(numberM, numberN);


void NumbersFromTillUp(int M, int N)
{
    if (M>N)
    {
        NumbersFromTillUp(M-1, N);
        Console.Write ($"{M} ");
    }
    else if (M<N)
    {
        NumbersFromTillUp(M, N-1);
        Console.Write ($"{N} ");
    }
    else
    {
        Console.Write ($"{N} ");
    }
}