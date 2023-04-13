// Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N. Выполнить с помощью рекурсии.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30
Console.Write("Введите натуральное число M: ");
int numberM = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите натуральное число N: ");
int numberN = Convert.ToInt32(Console.ReadLine());
//Console.Write ($"Сумма чисел от {numberM} до {numberN} = {SummNumbersBetween(numberM, numberN)}");
SummNumbersFromTill(numberM, numberN);

void SummNumbersFromTill(int M, int N)
{
    if (M == N) return N;
    int sum = 0;
    if (M>N)
    {
        SummNumbersFromTill(M, N+1);
        sum = sum + N;
    }
    return sum+N;
    if (M < N)
    {
        SummNumbersFromTill(M, N-1);
        sum = sum + N;
    }
    return sum;
    // {
    //     Console.Write ($" ");
    // }
}

// void SummNumbersBetween(int M, int N)
// {
//     if (N == M ||N == M +1 || N +1 == M) return;
//     //int sum = M+1;
//     if (N > M)
//     {
//         int sum = M+1;
//         SummNumbersBetween(M, N);
//         Console.Write (sum);
//     }
    // while (numM > numN)
    // {
    //     numN++;
    //     sum = sum + numN;
    //     SummNumbersBetween(numM, numN);
    // }
    
