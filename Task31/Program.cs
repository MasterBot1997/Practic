// // Задача 31: 
// 1. Задайте массив из 12 элементов, 
// 2. заполненный случайными числами из промежутка [-9, 9]. 
// 3. Найдите сумму отрицательных 
// 4. и положительных элементов массива.
// // Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма
// // положительных чисел равна 29, сумма отрицательных равна
// // -20

int[] CreateArrayRndInt(int size, int min, int max)
{
    int[] array = new int[size];
    Random rnd = new Random();
    for (int i = 0; i < size; i++)
    {
        array[i] = rnd.Next(min, max + 1);
    }
    return array;
}

void PrintArray(int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1) Console.Write($"{array[i]},");
        else Console.WriteLine($"{array[i]}");
    }
    Console.Write("]");
}

int[] GetSumPositiveNegativeElem(int[] array)
{
    int sumPositiv = 0;
    int sumNegativ = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0) sumPositiv += array[i];
        else sumNegativ += array[i];
    }

    return new int[]{sumPositiv, sumNegativ};
}

int[] arr = CreateArrayRndInt(12, -9, 9);
PrintArray(arr);
int[] getSumPositiveNegativeElem = GetSumPositiveNegativeElem(arr);
Console.WriteLine($"Сумма положительных элементов = {getSumPositiveNegativeElem[0]}");
Console.WriteLine($"Сумма отрицательных элементов = {getSumPositiveNegativeElem[1]}");