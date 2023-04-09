// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

int[] FillArray(int length)
{
    int[] arr = new int[length];
    Random rand = new Random();
    for (int i = 0; i < length; i++)
    {
        arr[i] = rand.Next(-100, 101);
    }
    return (arr);
}

void PrintArray(int[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length - 1; i++)
    {
        Console.Write($"{arr[i]}, ");
    }
    Console.Write(arr[arr.Length - 1]);
    Console.WriteLine("]");
}

int SummNumbersOnOddPozition (int[] arr)
{
    int sum = 0;
    for (int i =0; i <arr.Length; i++)
    {
        if (i%2 !=0) sum = sum + arr[i];
    }
    return sum;
}

Console.WriteLine("Ввведите длину массива: ");
int size = Convert.ToInt32(Console.ReadLine());
int[] array = FillArray(size);
PrintArray(array);
Console.WriteLine($"В данном массиве сумма элементов занимающих нечетные позиции ={SummNumbersOnOddPozition (array)}");