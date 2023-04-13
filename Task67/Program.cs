// Напишите программу, которая будет принимать на вход число и возвращать сумму его цифр.
// 453 -> 12
// 45 -> 9
Console.Write("Введите натуральное число N: ");
int number = Convert.ToInt32(Console.ReadLine());
Console.Write(SummDigitsNumber(number));

int SummDigitsNumber(int num)
{
    if (num == 0) return 0;
    else return SummDigitsNumber(num/10) +num%10;
}

