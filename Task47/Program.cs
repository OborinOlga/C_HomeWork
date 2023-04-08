// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

// int m = Prompt("Введите количество строк 2-хмерного массива:  ");
// int n = Prompt("Введите количество столбцов 2-хмерного массива:  ");
// double[,] array2d = CreateMatrixRndDouble(m, n, -19, 33);
// PrintMatrix(array2d);

// int Prompt (string message)
// {
//     System.Console.Write(message);
//     string ReadInput = System.Console.ReadLine();
//     int result = int.Parse(ReadInput);
//     return result;
// }

Console.Write(«Введите размерность cспрк в массиве: «);
int m = Convert.ToInt32(Console.ReadLine());
Console.Write(«Введите размерность n массива: «);
int n = Convert.ToInt32(Console.ReadLine());
double[,] randomArray = new double[m,n];

void mas(int m, int n)
{
Random rand = new Random();
    for (int i = 0; i < m; i++)
    {
        Console.WriteLine();
        for (int j = 0; j < n; j++)
        {
            randomArray[i,j] = rand.NextDouble();
            Console.Write($"{randomArray[i,j],  5} ");
        }
    }

}

mas(m,n);

// double[,] a = new double[5, 10];
 
// Random random = new Random();
// for (int i = 0; i < 5; i++)
// {
//     for (int j = 0; j < 10; j++)
//     {
//         a[i, j] = random.Next(100);
//         Console.Write("{0,4}", a[i, j]);
//     }
//     Console.WriteLine();
// }
// Код р


// double[,] CreateMatrixRndDouble (int rows, int columns, double min, double max)
// {
//     double[,] matrix = new double[rowsMatr, columnsMatr]; // 0, 1
//     Random rnd = new Random();
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             matrix[i, j] = rnd.NextDouble(min, max + 1);
//         }
//     }
//     return matrix;
// }

// void PrintMatrix(double[,] matrix)
// {
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         Console.Write("|");
//         for (int j = 0; j < matrix.GetLength(1); j++)
//             {
//                 Console.Write($"{matrix[i, j], 5} ");
//             }
//             Console.WriteLine("|");
//     }
// }


