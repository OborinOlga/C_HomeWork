// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3.5, 7.1, 22.9, 2.3, 78.5] -> 76.2

double[] FillArray (int size)
{
    double[] arr = new double[size];
    Random rand = new Random();
    for (int i=0; i <size; i++)
    {
        arr[i] = Math.Round(rand.NextDouble() *100,  2);
    }
    return (arr);
}

void PrintArray (double[] arr)
{
    Console.Write("[");
    for (int i=0; i <arr.Length-1; i++)
    {
        Console.Write($"{arr[i]}, ");
    }
    Console.Write(arr[arr.Length-1]);
    Console.WriteLine("]");
}

double DifferenceMaxMinNumbers(double[] arr)
{
      double min = arr[0];
      double max = arr[0];
      for (int i =0; i< arr.Length; ++i)
      {
        if (arr[i] < min) min = arr[i];
        if (arr[i] > max) max = arr[i];
      }
    return (Math.Round(max-min,  2));
}


Console.Write ("Введите длину массива: ");
int length = Convert.ToInt32(Console.ReadLine());
double[] array = FillArray(length);
PrintArray(array);
Console.Write ($"Разница между максимальным и минимальным элементами массива ={DifferenceMaxMinNumbers(array)}");

