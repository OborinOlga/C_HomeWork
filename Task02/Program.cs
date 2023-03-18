// Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
Console.WriteLine("Введите первое натуральное число: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе натуральное число: ");
int number2 = Convert.ToInt32(Console.ReadLine());

if(number1 > number2)
{
    Console.WriteLine($"Наибольшее число = {number1}");
}
else if (number1 < number2)
{
    Console.WriteLine($"Наибольшее число = {number2}");
}
else
{
    Console.WriteLine("Числа равны");
}