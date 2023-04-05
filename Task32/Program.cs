// Задача 32: Напишите программу замена элементов массива: положительные элементы замените на
// соответствующие отрицательные, и наоборот.
// [-4, -8, 8, 2] -> [4, 8, -8, -2]

// ВВод числа с экрана
int Prompt (string message)
{
    System.Console.Write(message);
    string ReadInput = System.Console.ReadLine();
    int result = int.Parse(ReadInput);
    return result;
}

// Метод заполнения массива
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

 // Метод инверсии элементов массива по знаку
void PrintInversArray(int[] arr)
{
    System.Console.Write("[");
    for (int index = 0; index < arr.Length-1; index++)
    {
        arr[index] = arr[index]*-1;
        System.Console.Write($"{arr[index]}, ");
    }
    System.Console.Write($"{arr[arr.Length-1]}");
    System.Console.WriteLine("]");
}

int length = Prompt("Введите длину массива: ");
int min = Prompt("Введите начальное значение для  диапазона случайных чисел массива:  ");
int max = Prompt("Введите конечное значение для  диапазона случайных чисел массива:  ");
int[] array = FillArray(length, min, max);
PrintArray(array);
PrintInversArray(array);
