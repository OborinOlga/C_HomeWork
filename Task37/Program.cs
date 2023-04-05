// Задача 37: Найдите произведение пар чисел в одномерном массиве.
// Парой считаем первый и последний элемент, второй и предпоследний и т.д. Результат запишите в новом массиве.
// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 36 21

// ВВод числа с экрана
int Prompt (string message)
{
    Console.Write(message);
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

//  Метод выведения в виде элементов массива произведения пар чисел с концов
void NewArray (int[] arr)
{
    int start = 0;
    int end = arr.Length-1;
    for (int count = 0; count <= (arr.LongLength-1)/2; count++)  
    {

        if (start+count < end-count)
        {
            int product=arr[start+count]*arr[end-count];
            Console.Write($"{product}, ");
        }
        else Console.Write(arr[start+count]);
    }
}

//  Метод выведения в виде элементов массива произведения пар чисел с концов
// void NewArray (int[] arr)
// {
//     int numStart = arr[0];
//     int numEnd = arr[arr.Length-1];
//     int product=numStart*numEnd;
//     Console.Write($"[{product}, ");
//     for (int step = 1; step <= arr.Length/2; step++)  
//     {
//         if (step < arr.Length/2)
//         {
//             numStart = arr[step];
//             numEnd = arr[arr.Length-1-step];
//             product=numStart*numEnd;
//             Console.Write($"{product}, ");
//         }
//         else if (step < arr.Length/2) Console.Write($"{arr[step]}]");
//     }
// }

int length = Prompt("Введите длину массива: ");
int min = Prompt("Введите начальное значение для  диапазона случайных чисел массива:  ");
int max = Prompt("Введите конечное значение для  диапазона случайных чисел массива:  ");
int[] array = FillArray(length, min, max);
PrintArray(array);
NewArray (array);