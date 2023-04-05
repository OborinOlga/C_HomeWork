// Задача 33: Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.
// 4; массив [6, 7, 19, 345, 3] -> нет
// 3; массив [6, 7, 19, 345, 3] -> да
Console.WriteLine("введите длину массива: ");
int arraySize = Convert.ToInt32(Console.ReadLine());
int[] array=new int[arraySize];
Console.WriteLine("введите искомое число: ");
int number = Convert.ToInt32(Console.ReadLine());

FillArray(array);
PrintArray (array);
Console.WriteLine(FindNum(number, array) ? "Есть искомое число" : "Нет искомого числа");



void FillArray(int[] arr)
{
    Random rnd = new Random();
    for (int i=0; i < arr.Length; i++)
    {
    arr[i] = rnd.Next(-10, 11);
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

bool FindNum(int num, int[] arr)
{
    for (int i=0; i < arr.Length; i++)
    {
    if (num== arr[i]) return true;
    }
    return false;
}

