//Напишите программу, которая выводит случайное число 
// из отрезка [10, 99] и показывает наибольшую цифру числа

int number = new Random ().Next(10, 100);
Console.WriteLine($"Случайное число из отрезки 10-99-> {number}");

int firstDigit = number / 10;
int secondDigit = number % 10;

if ( firstDigit >= secondDigit) 
{
    Console.Write(firstDigit);
}
else 
{
    Console.WriteLine(secondDigit);
}