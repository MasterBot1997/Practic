// Задача 55: Задайте двумерный массив. Напишите программу,
// которая заменяет строки на столбцы. В случае, если это
// невозможно, программа должна вывести сообщение для
// пользователя.

int[,] CreateMatrixRndInt(int rows, int columns, int min, int max)
{
    int[,] matrix = new int[rows, columns];
    Random rnd = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(min, max + 1);
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
            if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j],2} |");
            else Console.Write($"{matrix[i, j],2}");
        }
        Console.WriteLine(" |");
    }
}

int[,] RePlaceRowsColumns(int[,] matr)
{
    int[,] newMatrix = new int[matr.GetLength(0), matr.GetLength(1)];
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            newMatrix[i,j] = matr[j,i];
        }

    }
    return newMatrix;
}

int[,] array2D = CreateMatrixRndInt(4, 4, 1, 10);
if (array2D.GetLength(0) == array2D.GetLength(1))
{
    PrintMatrix(array2D);
    int[,] newArray2D = RePlaceRowsColumns(array2D);
    Console.WriteLine();
    PrintMatrix(newArray2D);
}
else Console.Write("Невозможно заменить строки на столбцы");