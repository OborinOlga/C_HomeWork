// Напишите программу, которая вывоодит случайное трехзначное число
// и удаляет вторую цифру этого числа

int number = new Random().Next(100, 1000);
Console.WriteLine($"случайное число из отрезка от 100 до 999 -> {number}");

// int firstDigit = number / 100;
// int thirdDigit = number % 10;
// int newNumber = 10*firstDigit + thirdDigit;
// Console.WriteLine(newNumber);

int FirstThirdDigit (int num)
int firstDigit = number / 100;
int thirdDigit = number % 10;
int newNumber = 10*firstDigit + thirdDigit;
int newNumber = 10*firstDigit + thirdDigit;