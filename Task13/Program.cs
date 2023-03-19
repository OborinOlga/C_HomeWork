// See https://aka.ms/new-console-template for more information
int BigNumber (int num)
{
    int newNum = num / 10;
    return newNum;
}

Console.WriteLine("Введите наруральное число: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number > 99)
{
    while (number > 999)
    {
        number= BigNumber(number);
    }
    int thirdDigit = number%10;    
    Console.WriteLine($"Третяя цифра числа слева: {thirdDigit}");
}
else
{
    Console.WriteLine("Количество цифр в числе меньше трёх");
}