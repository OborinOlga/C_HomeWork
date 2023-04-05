// Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, 
// которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

// ВВод числа с экрана
int Prompt (string message)
{
    Console.Write(message);
    string ReadInput = System.Console.ReadLine();
    int result = int.Parse(ReadInput);
    return result;
}

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
int QuantityEvenNumber(int[] arr)
{
    for (int i= 0; i <= arr.Length-1; i++)  
    {
        int result=0;
        if (arr[i]%2 ==0) result=result+1;
        else result=result;
    }
}


int length = Prompt("Введите длину массива: ");
int[] array = FillArray(length);
PrintArray(array);
Console.WriteLine($"В данном массиве количество чётных чисел = {QuantityEvenNumber[array]}");
