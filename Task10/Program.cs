//  Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

// Метод
int SecondDigit (int num)
{
    int firstDigit = num/100;
    int thirdDigit = num%10;
    int SecondNum = (num - firstDigit*100 - thirdDigit)/10;
    return SecondNum;
}

Console.WriteLine("Введите натуральное трёхзначное число:  ");
int number = Convert.ToInt32(Console.ReadLine());

if (99 < number)
{
     if (number < 1000)
     {
        int secondDigit = SecondDigit(number);
        Console.WriteLine($"Вторая цифра числа: {secondDigit}");
     }
    else 
     {
        Console.WriteLine("Число не соответствует критерию - трёхзначность");
     }
}
else
{
    Console.WriteLine("Число не соответствует критерию - трёхзначность");
}

