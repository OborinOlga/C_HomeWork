// Задача 39: Напишите программу, которая перевернёт одномерный массив (последний элемент будет на первом
// месте, а первый - на последнем и т.д.)
// [1 2 3 4 5] -> [5 4 3 2 1]
// [6 7 3 6] -> [6 3 7 6]

int[] FillArray(int size)
{
    int[] arr = new int[size];
    Random rand = new Random();
    for (int i = 0; i<size; i++)
    {
        arr[i] = rand.Next(-10, 11);
    }
    return(arr);
}

void PrintArray (int[] arr)
{
    Console.Write("[");
    for(int i=0; i <arr.Length-1; i++)
    {
        Console.Write($"{arr[i]}, ");
    }
    Console.Write(arr[arr.Length-1]);
    Console.WriteLine("]");
}

void FillReverseArray(int[] arr)
{
    int temp = 0;
    for (int i =0; i < (arr.Length+1)/2; i++)
    {
        temp = arr[i];
        arr[i] = arr[arr.Length-1-i];
        arr[arr.Length-1-i] = temp;
    }
}

Console.WriteLine("Введите длтну массива: ");
int length = Convert.ToInt32(Console.ReadLine());
int[] array = FillArray(length);
PrintArray(array);
FillReverseArray(array);
PrintArray(array);

Array.Reverse (array);
PrintArray (array);
