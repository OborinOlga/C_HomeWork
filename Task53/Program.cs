// Задача 53: Задайте двумерный массив. Напишите программу,которая поменяет местами первую 
// и последнюю строку массива.

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
                Console.Write($"{matrix[i, j], 5} ");
            }
            Console.WriteLine("|");
    }
}

void ChangeFirstLastRows (int [,] matrix)
{
    int firstRow = 0;
    int lastRow = matrix.GetLength(0)-1;
    int temp = 0;
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        temp = matrix[firstRow, j];
        matrix[firstRow, j] = matrix[lastRow, j];
        matrix[lastRow, j] = temp;
    }      
}

Console.Write("Введите размерность cтрок в массиве m: ");
int mRows = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите размерность в массиве n: ");
int nColumns = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите минимальное значение элементов массива: ");
int minValue = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите максимальное значение элементов массива: ");
int maxValue = Convert.ToInt32(Console.ReadLine());
int[,] array2d = CreateMatrixRndInt(mRows, nColumns, minValue, maxValue);
PrintMatrix(array2d);
ChangeFirstLastRows (array2d);
Console.WriteLine();
PrintMatrix(array2d);
