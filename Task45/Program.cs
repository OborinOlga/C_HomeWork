// Задача 45: Напишите программу, которая будет создавать копию заданного массива 
// c помощью поэлементного копирования.

int [] FillArray (int Length, int minValue, int maxValue)
{
    int[] arr = new int[Length];
    Random rand = new Random();
    for (int i = 0; i < Length; i++)
    {
        arr[i] =rand.Next(minValue, maxValue+1);
    }
    return arr;
}

void PrintArray (int[] arr)
{
    Console.Write("[");
    for(int i=0; i <arr.Length; i++)
    {
        if (i< arr.Length-1) Console.Write($"{arr[i]}, ");
        else Console.Write(arr[arr.Length-1]);
    }
    Console.WriteLine("]");
}

int[] CopyArray (int[] arr)
{
    int[] newArr =new int[arr.Length];
    for (int i =0; i <arr.Length; i++)
    {
        newArr[i] = arr[i];
    }
    return newArr;
}


Console.WriteLine("Введите длину массива: ");
int length = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите начальное значение для  диапазона случайных чисел массива:  ");
int min = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите конечное значение для  диапазона случайных чисел массива: ");
int max = Convert.ToInt32(Console.ReadLine());
int[] array = FillArray(length, min, max);
PrintArray(array);
int[] newArray = CopyArray(array);
PrintArray(newArray);
