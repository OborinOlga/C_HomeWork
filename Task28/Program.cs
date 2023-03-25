// напишите программу, которая на вход принимает число N и выдает произведение чисел от 1 до N.


int Factorial (int num)
{
    int fact = num;
    for (int newnum= num-1; newnum > 1; newnum=newnum-1)
    {
        checked
        {
        fact = fact * newnum;
        }
    }
    return fact;
}


Console.WriteLine("Введите натуральнео число: ");
int number= Convert.ToInt32(Console.ReadLine());

if (number < 1)
{
    Console.WriteLine($"Факториал числа {number} = 0");
}
else 
{
    int factorial= Factorial(number);
    Console.WriteLine($"Факториал числа {number} = {factorial}");
}