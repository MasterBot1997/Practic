// Задача 51: Задайте двумерный массив. Найдите сумму
// элементов, находящихся на главной диагонали (с индексами
// (0,0); (1;1) и т.д.

int[,] CreateMatrixRndInt(int rows, int columns, int min, int max)
{
    int[,] matrix = new int[rows, columns];
    Random rnd = new Random();

    for (int i = 0; i < matrix.GetLength(1); i++) // 2
    {
        for (int j = 0; j < matrix.GetLength(0); j++) //
        {
            matrix[i, j] = rnd.Next(min, max + 1); // 2 - 3
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
            if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j],3}|");
            else Console.Write($"{matrix[i, j],3}");
        }
        Console.WriteLine(" |");
    }
}

// int MatrixPositiveNumber(int[,] mat)
// {
//     int res = 0;
//     for (int i = 0; i < mat.GetLength(0); i++)
//     {
//         for (int j = 0; j < mat.GetLength(1); j++)
//         {
//             if (i == j) res = res + mat[i, j];
//         }
//     }
//     return res;
// }

// Альтернативная верисия решения с количеством операций в 2 раза меньше 

int CalcSummDiagonal(int[,] matrix)
{
    int sum = default;
    int diag = default;

    if (matrix.GetLength(0) > matrix.GetLength(1))
        diag = matrix.GetLength(1);
    else
        diag = matrix.GetLength(0);

    for (int i = 0; i < diag; i++)
    {
        sum += matrix[i, i];
    }

    return sum;
}

int[,] array2D = CreateMatrixRndInt(4, 4, 1, 10);
PrintMatrix(array2D);
Console.WriteLine();
// int result = MatrixPositiveNumber(array2D); 
int result = CalcSummDiagonal(array2D);
Console.WriteLine($"{result}");
