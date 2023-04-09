// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение 
// этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
//  1 4 7 2
//  5 9 2 3
//  8 4 2 4
//  1, 7 -> такого элемента в массиве нет

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

void FindElemet (int [,] matrix, int m, int n)
{
    if (m < matrix.GetLength(0)) 
    {
        if (n < matrix.GetLength(1)) Console.WriteLine($"Значение запрашиваемого элемента равно {matrix[n, m]}");
        else Console.WriteLine("Запрашиваемый элемент в массиве отсутствует");
    }
    else Console.WriteLine("Запрашиваемый элемент в массиве отсутствует");
}

int[,] array2d = CreateMatrixRndInt(3, 5, -10, 10);
PrintMatrix(array2d);
Console.Write("Введите позиция в строке запрашиваемого элемента - m: ");
int mPosition = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите позиция в столбце запрашиваемого элемента - n: ");
int nPosition = Convert.ToInt32(Console.ReadLine());
FindElemet (array2d, mPosition, nPosition);
