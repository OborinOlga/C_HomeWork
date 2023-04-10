// Задача 55: Задайте двумерный массив. Напишите программу, которая заменяет строки на столбцы. 
// В случае, если это невозможно, программа должна вывести сообщение для пользователя.

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

void ChangeFirstLastRows(int[,] matrix)
{
    if (matrix.GetLength(0) != matrix.GetLength(1))
    {
        Console.Write("Перевернуть массив не получится, т.к. размерность строк не совпадает с размерностью столбцов");
    }
    else
    {
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = i; j < matrix.GetLength(1); j++)
            {
                int temp = 0;
                temp = matrix[i, j];
                matrix[i, j] = matrix[j, i];
                matrix[j, i] = temp;
            }
        }
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
ChangeFirstLastRows(array2d);
Console.WriteLine();
PrintMatrix(array2d);
