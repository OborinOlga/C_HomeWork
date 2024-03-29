﻿// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11     82 -> 10   9012 -> 12

int SummDigit(int num)
{
    int sum = 0;
    while (num > 0)
    {
        sum = sum + num % 10;
        num = num / 10;
    }
    return sum;
}

Console.WriteLine("Введите натуральное число: ");
int number = Convert.ToInt32(Console.ReadLine());

int summDigit = SummDigit(number);
Console.WriteLine($"Сумма цифр, из которого состоит число {number} = {summDigit}");