// Задача 57: Составить частотный словарь элементов
// двумерного массива. Частотный словарь содержит
// информацию о том, сколько раз встречается элемент
// входных данных.

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

int[] NewArray(int[,] matr)
{
    int k = default;
    int[] newArr = new int[matr.GetLength(0) * matr.GetLength(1)];
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            newArr[k] = matr[i, j];
            k++;
        }

    }
    return newArr;
}

void PrintArray(int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1) Console.Write($"{array[i]},");
        else Console.Write($"{array[i]}");
    }
    Console.WriteLine("]");
}

void CountElements(int[] array)
{
    int elem = array[0];
    int count = 1;
    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] == elem) count++;
        else
        {
            Console.WriteLine($"Элементов {elem} => {count}");
            elem = array[i];
            count = 1;
        }
    }
    Console.WriteLine($"Элементов {elem} => {count}");
}

int[,] array2D = CreateMatrixRndInt(4, 4, 1, 10);
PrintMatrix(array2D);
Console.WriteLine("-----------------------------");
int[] arr = NewArray(array2D);
Array.Sort(arr);
PrintArray(arr);
Console.WriteLine("-----------------------------");
CountElements(arr);
