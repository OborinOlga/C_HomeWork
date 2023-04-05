// Задача 35: Задайте одномерный массив из 123 случайных чисел.
// Найдите количество элементов массива, значения которых лежат в отрезке [10,99].
// Пример для массива из 5, а не 123 элементов. В своём решении сделайте для 123
// [5, 18, 123, 6, 2] -> 1
// [1, 2, 3, 6, 2] -> 0
// [10, 11, 12, 13, 14] -> 5
Console.WriteLine("Введите длину массива: ");
int arraySize = Convert.ToInt32(Console.ReadLine());
int[] array=new int[arraySize];
Console.WriteLine("Введите нижнюю границу диапазона для поиска: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите верхнюю границу диапазона для поиска: ");
int max = Convert.ToInt32(Console.ReadLine());

FillArray(array);
PrintArray (array);
Console.WriteLine($"Количество элементов массива, которые лежат в диапазоне [{min},{max}] равно {QuantityFindNumber(min, max, array)}");

void FillArray(int[] arr)
{
    Random rnd = new Random();
    for (int i=0; i < arr.Length; i++)
    {
    arr[i] = rnd.Next(-200, 200);
    }
}

void PrintArray(int[] arr)
{
    for (int i=0; i < arr.Length; i++)
    {
    if (i !=arr.Length-1) Console.Write($"{arr[i]}, ");
    else Console.WriteLine(arr[i]);
    }
}

int QuantityFindNumber(int minValue, int maxValue, int[] arr)
{
    int rezult = 0;
    for (int i=0; i < arr.Length; i++)
    {
    if (arr[i] >= minValue & arr[i] <= maxValue) rezult++;
    }
    return rezult;
}

