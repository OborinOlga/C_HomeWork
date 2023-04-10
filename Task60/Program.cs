// Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет 
// построчно выводить массив, добавляя индексы каждого элемента. Массив размером 2 x 2 x 2
// Результат:
// 66(0,0,0) 27(0,0,1) 25(0,1,0) 90(0,1,1)
// 34(1,0,0) 26(1,0,1) 41(1,1,0) 55(1,1,1)

int[,,] CreateArray3dRndInt(int lists, int rows, int columns, int min, int max)
{
    int[,,] matrix = new int[lists,rows, columns];

    Random rand = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                for (int k = 0; k < matrix.GetLength(2); k++)
                {
                    matrix[i, j, k] = rand.Next(min, max + 1);
                }
             }
        }
    return matrix;
}

void PrintMatrix(int[,,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.WriteLine($"Лист {i+1} 3D массива");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write("|");
            for (int k = 0; k < matrix.GetLength(2); k++)
            {
                Console.Write($"{matrix[i, j, k], 3} ");
            }
            Console.WriteLine("|");
            Console.WriteLine();
        }
    }
}

Console.Write("Введите количество листов в массиве l: ");
int lLists = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите размерность cтрок в массиве m: ");
int mRows = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите размерность столбцов в массиве n: ");
int nColumns = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите минимальное значение элементов в массиве: ");
int minValue = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите максимальное значение элементов в массиве: ");
int maxValue = Convert.ToInt32(Console.ReadLine());
int[,,] array3d = CreateArray3dRndInt(lLists, mRows, nColumns, minValue, maxValue);
PrintMatrix(array3d);


