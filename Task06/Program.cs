// Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
Console.WriteLine("Введите первое натуральное число: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе натуральное число: ");
int number2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите третее натуральное число: ");
int number3 = Convert.ToInt32(Console.ReadLine());

if (number1 >= number2)
{
    if (number1 >= number3)
    {
        Console.WriteLine($"Наибольшее число = {number1}");
    }
    else
    {
        Console.WriteLine($"Наибольшее число = {number3}");
    }
}
else if (number2 >= number3)
{
     Console.WriteLine($"Наибольшее число = {number2}");
}
else
{
     Console.WriteLine($"Наибольшее число = {number3}");
}


