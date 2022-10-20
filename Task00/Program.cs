// Напишите программу, которая
// 1. на вход принимают число и
// 2. выдает его квадрат (число умножения на само себя).

// Например:
// 4 -> 16
// -3 -> 9
// -7 -> 49

Console.Write("Введите целое число: ");
int number = Convert.ToInt32(Console.ReadLine());

// string str = Console.ReadLine();
// int num = Convert.ToInt32(str);

int square = number * number;
Console.WriteLine($"Квадрат числа {number} = {square}");




