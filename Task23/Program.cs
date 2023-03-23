// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

void Cube (int n)
{
    int i = 1;
    // for ( ; i < n; i++);
    // Console.WriteLine($"{i, 4} -> {i*i*i, 4}");
while (i <= n)
{
    Console.WriteLine($"{i, 4} -> {i*i*i, 4}");
    i ++;
}
}

Console.WriteLine("Введите натуральное число:  ");
int N = Convert.ToInt32(Console.ReadLine());

if (N > 0)
{
    Cube(N);
}
else 
{
    Console.WriteLine("Введено некорректное число");
}
