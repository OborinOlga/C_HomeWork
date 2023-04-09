// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// -1, -7, 567, 89, 223-> 3

int[] CreateArrey (int num)
{
    int[] arr = new int[num];
    for (int i = 0; i < num; i++)
    {
        Console.Write ("Введите число массива: ");
        arr[i] = Convert.ToInt32(Console.ReadLine());
    }
    return (arr);
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

int HowManyPozitiveElements(int[] arr)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i]>0) count++;
    }
    return count;
}

Console.WriteLine("Введите длину массива: ");
int M = Convert.ToInt32(Console.ReadLine());
int[] array = CreateArrey(M);
PrintArray(array);
Console.WriteLine($"В данном массиве количество положительных элементов ={HowManyPozitiveElements (array)}");

