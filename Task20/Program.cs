//  Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

// 1-й способ 

bool Pal (int num)
{
    return num%10 == num/10000%10 && num/10%10 == num/1000%10;
}

Console.WriteLine("Введите натуральное пятизначное число:  ");
int number = Convert.ToInt32(Console.ReadLine());

if (number < 100000 && number > 9999)
{
    bool pal = Pal(number);
    Console.WriteLine(pal ? "Число является палиндромом" : "Нет, данное число не палиндром");
}
else
{
    Console.WriteLine("Число не является пятизначным");
}


