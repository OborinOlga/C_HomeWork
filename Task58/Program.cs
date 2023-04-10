// Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

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

void MultipleTwoMatrix(int[,] matrA, int[,] matrB)
{
    for (int i = 0; i < matrA.GetLength(0); i++)
    {
        Console.Write("|");
        for (int j = 0; j < matrA.GetLength(1); j++)
        {
            int res = matrA[i, j] * matrB[i, j];
            Console.Write($"{res, 5} ");
        }
        Console.WriteLine("|");
    }
}

Console.Write("Введите размерность cтрок в массивах m: ");
int mRows = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите размерность в массивах n: ");
int nColumns = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите минимальное значение элементов в массивах: ");
int minValue = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите максимальное значение элементов в массивах: ");
int maxValue = Convert.ToInt32(Console.ReadLine());
int[,] array2dFirst = CreateMatrixRndInt(mRows, nColumns, minValue, maxValue);
PrintMatrix(array2dFirst);
Console.WriteLine();
int[,] array2dSecond = CreateMatrixRndInt(mRows, nColumns, minValue, maxValue);
PrintMatrix(array2dSecond);
Console.WriteLine();
MultipleTwoMatrix(array2dFirst, array2dSecond);