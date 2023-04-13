// Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"


Console.Write("Введите натуральное число N: ");
int number = Convert.ToInt32(Console.ReadLine());
Console.Write($"'");
ReserveNaturalNumbers (number);
Console.Write("'");

void ReserveNaturalNumbers (int num)
{
    Console.Write(num);
    if (num==1) return;
    Console.Write(", ");
    ReserveNaturalNumbers (num-1);
    
    
}
   
