// Напишите программу, которая будет принимать на ввод двачисла и выводить,
// является ли первое число кратным второму. Если число 1 не кратно числу 2, то
// программа выводит остаток от деления.

Console.WriteLine("Введите первое целое число:  ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе целое число:  ");
int number2 = Convert.ToInt32(Console.ReadLine());

// if (number1 >= number2)
// {
//     if (number1 % number2 == 0)
//     {
//         Console.WriteLine("Первое число кратно второму");
//     }
//     else
//     {
//         while (number1 > number2)
//         {
//             number1 = number1 - number2;
//         }
//         Console.WriteLine($"Остаток от деления = {number1}");
//     }
// }
// else
// {
//     Console.WriteLine("Первое число меньше второго");
// }

// 2й способ
// int result = number1%number2;
// if (result==0)
// {
//      Console.WriteLine("Кратно");
// }
// else
// {
//      Console.WriteLine($"Не кратно, остаток от деления = {result}");
// }

// 3й способ и использованием методов
int Multiple (int num1, int num2)
{
    return num1%num2;
}

int result = Multiple (number1, number2);
if (result == 0)
{
    Console.WriteLine ("Кратно");
}
else
{
    Console.WriteLine ($"Не кратно, остаток от деления = {result}");
}