// Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
Console.WriteLine("Введите натуральное число: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number < 0) number *= -1;
if (number == 0)
{
    Console.WriteLine("Число не является ни чётным, ни нечётным");
}

else
{
    if (number%2 ==1)
    {
        Console.WriteLine("Число является нечётным");
    }
    else
    {
        Console.WriteLine("Число является чётным");
    }
}
