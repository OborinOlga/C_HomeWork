// Напишите программу, которая на вход принимает два числа A и B, и возводит число А 
// в целую степень B с помощью рекурсии.
// A = 3; B = 5 -> 243 (3⁵)
// A = 2; B = 3 -> 8
Console.Write("Введите натуральное число A: ");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите натуральное число B: ");
int numberB = Convert.ToInt32(Console.ReadLine());
Console.Write(DegreeDecreasingNumber(numberA, numberB));

int DegreeDecreasingNumber(int A, int B)
{
    if (B == 1) return A;
    else return checked (A * DegreeDecreasingNumber(A, B-1));
}

