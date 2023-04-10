// Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

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
    for (int i = 0; j < matrix.GetLength(0); j++)
    {
        
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            int temp = 0;
            if (matrix[i, j+1] > matrix[i, j]) temp = matrix[i, j] ;
            matrix[i, j] = matrix[i, j+1];
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

