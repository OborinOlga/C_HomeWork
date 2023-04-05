// // Задача 31: Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9]. Найдите сумму
// отрицательных и положительных элементов массива. Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма
// положительных чисел равна 29, сумма отрицательных равна -20.

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

 // Метод для подсчета суммы положительных элементов
int SumPozElem (int[] arr)
{
    int sum = 0;
    for (int index = 0; index < arr.Length; index++)
    {
        if (arr[index] > 0) sum = sum + arr[index];
    }
    return sum;
    
}

//  Метод для подсчета суммы отрицательных элементов
int SumNegElem (int[] arr)
{
    int sum = 0;
    for (int index = 0; index < arr.Length; index++)
    {
        if (arr[index] < 0) sum = sum + arr[index];
    }
    return sum;
}

 

int length = Prompt("Введите длину массива: ");
int min = Prompt("Введите начальное значение для  диапазона случайных чисел массива:  ");
int max = Prompt("Введите конечное значение для  диапазона случайных чисел массива:  ");
int[] array = FillArray(length, min, max);
PrintArray(array);
System.Console.Write($"Сумма положительных элементов массива = {SumPozElem(array)}, отрицательных элементов массива = {SumNegElem(array)}");