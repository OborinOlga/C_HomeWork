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
            Console.Write($"{matrix[i, j],5} ");
        }
        Console.WriteLine("|");
    }
}

// static void BubbleSort(int[] inArray)
// {
//     for (int i = 0; i < inArray.Length; i++)
//         for (int j = 0; j < inArray.Length - i - 1; j++)
//         {
//             if (inArray[j] > inArray[j + 1])
//             {
//                 int temp = inArray[j];
//                 inArray[j] = inArray[j + 1];
//                 inArray[j + 1] = temp;
//             }
//         }
// }




//тот же метод пузырька
// void BubbleSort(int[,] matrix)
// {
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         void BubbleSort(int[,] matrix)
//         {
//             for (int i = 0; i < matrix.GetLength(0); i++)
//             {
//                 for (int j = 0; j < matrix.GetLength(1) - 1; j++)
//                 {
//                     if (matrix[i, j] > matrix[i, j + 1])
//                     {
//                         int temp = matrix[i, j];
//                         matrix[i, j] = matrix[i, j + 1];
//                         matrix[i, j + 1] = temp;
//                     }
//                 }
//             }
//         }
//     }
// }

//static int[,] BubbleSort(int[,] matrix)
void BubbleSort(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        int temp = 0;
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int k = j + 1; k < matrix.GetLength(1); k++)
            {
                if (matrix[i, j] > matrix[i, k])
                {
                    temp = matrix[i, j];
                    matrix[i, j] = matrix[i, k];
                    matrix[i, k] = temp;
                }                   
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
Console.WriteLine();
BubbleSort(array2d);
PrintMatrix(array2d);

