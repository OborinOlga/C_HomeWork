// напишите программу, которая принимает на вход  число, а выдает кол-во цифр в нём

int QuantityDigits (int num)
{
    int count = 0;
    while (num != 0)
    {
        num = num/10;
        count++;
    }
    return count;
}

Console.WriteLine("Введите целое число");
int number = Convert.ToInt32(Console.ReadLine());


if (number == 0)
{
    Console.WriteLine($"Число {number} состот из из 1 цифры");
}
else
{
    int quantityDigits = QuantityDigits (number);
    Console.WriteLine($"Число {number} состот из из {quantityDigits} цифр");
}



// Console.WriteLine("Введите число:  ");
// string number = Console.ReadLine();
// int length = number.Length;
// Console.WriteLine(length);