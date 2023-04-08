// Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, 
// которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

// Метод заполнения массива
int [] FillArray (int Length)
{
    int[] arr = new int[Length];
    Random rand = new Random();
    for (int i = 0; i < Length; i++)
    {
        arr[i] =rand.Next(100, 1000);
    }
    return arr;
}

// Метод вывода массива на экран
void PrintArray (int[] arr)
{   
    System.Console.Write("[");
    for (int i = 0; i < arr.Length-1; i++)
    {
        System.Console.Write($"{arr[i]}, ");
    }
    System.Console.Write($"{arr[arr.Length-1]}");
    System.Console.WriteLine("]");
}

// Метод подсчета четных чисел в массиве
int HowManyEvenNumber(int[] arr)
{
    int count=0;
    for (int i= 0; i <= arr.Length-1; i++)  
    {
        if (arr[i]%2 ==0) count++;
    }
    return count;
}

Console.WriteLine("Введите длину массива: ");
int length = Convert.ToInt32(Console.ReadLine());
int[] array = FillArray(length);
PrintArray(array);
Console.WriteLine($"В данном массиве количество чётных чисел = {HowManyEvenNumber(array)}");
