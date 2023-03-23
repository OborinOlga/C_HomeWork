// Напишите программу, которая принимает на вход число (N) и выдает таблицу квадратов чисел от 1 до N

void Quadro(int n)
{
    int i = 1;
    // for ( ; i < n; i++);
    // Console.WriteLine($"{i, 4} -> {i*i, 4}");
while (i <= n)
{
    Console.WriteLine($"{i, 4} -> {i*i, 4}");
    i ++;
}
}


Console.WriteLine("Введите натуральное число:  ");
int N = Convert.ToInt32(Console.ReadLine());

if (N >0)
{
    Quadro(N);
}
else 
{
    Console.WriteLine("Введен о некорректное число");
}



