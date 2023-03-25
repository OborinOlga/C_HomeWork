// Напишите программу, которая выводитт массив из 8 элементов, заполненный нулями и единицами в случайном порядке


int[] array = new int[8];
FillArray(array);
PrintArray(array);


void FillArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        array[i] = new Random().Next(0, 2);
    }
}

void PrintArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write(arr[i]+" ");
    }
}
