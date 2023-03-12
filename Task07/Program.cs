// Напишите программу, которая принимает на вход
// трёхзначное число и на выходе показывает последнюю цифру
// этого числа.
// 456 -> 6
// 782 -> 2
// 918 -> 8
Console.WriteLine("Введите трёхзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number < 0) number *= -1;
if (number > 99 && number < 1000)
{
    while (number > 9)
    {
        number = number - 10;
    }
    Console.WriteLine(number);
}
else
{
    Console.WriteLine("Проверьте трёхзначность числа и посторите воод");
}