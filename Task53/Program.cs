// Задача 53: Задайте двумерный массив. Напишите программу,
// которая поменяет местами первую и последнюю строку
// массива.

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

void RePlaceFirstLastRows(int[,] matr)
{
    int i = 0;
    for (int j = 0; j < matr.GetLength(1); j++)
    {
        int temp = matr[i,j];
        matr[i,j] = matr[matr.GetLength(0) - 1,j];
        matr[matr.GetLength(0) - 1,j] = temp;  
    }
}

int[,] array2D = CreateMatrixRndInt(4, 4, 1, 10);
PrintMatrix(array2D);
Console.WriteLine();
RePlaceFirstLastRows(array2D);
PrintMatrix(array2D);