// Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

int[,] CreateMatrixRndInt(int rows, int columns, int min, int max)
{
    int[,] matrix = new int[rows, columns]; // 0, 1

    Random rand = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rand.Next(min, max + 1);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("|");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j],5} ");
        }
        Console.WriteLine("|");
    }
}

int[] ArraySumElementsOnRows (int [,] matrix, int rows)
{
    int[] arrSum = new int[rows];
    for (int i=0; i < rows; i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            arrSum[i] = arrSum[i] + matrix[i, j];
            
        }
        // Console.Write ($" {arrSum[i]}, ");
    } 
    return arrSum;
 }

void FindMin (int[] arr)
{
    //int min = 0;
    int minPoz = 1;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] < arr[minPoz])  minPoz = i+1;
    }
    Console.WriteLine($"Наименьшая сумма элементов расположена в {minPoz}-ой стоке");
} 

Console.Write("Введите размерность cтрок в прямоугольном массиве m: ");
int mRows = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите размерность в прямоугольном массиве n: ");
int nColumns = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите минимальное значение элементов массива: ");
int minValue = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите максимальное значение элементов массива: ");
int maxValue = Convert.ToInt32(Console.ReadLine());
int[,] array2d = CreateMatrixRndInt(mRows, nColumns, minValue, maxValue);
PrintMatrix(array2d);
int[] array = ArraySumElementsOnRows(array2d, mRows);
FindMin(array);

