// Задача 67: Напишите программу, которая будет принимать на вход число и
// возвращать сумму его цифр.
// 453 -> 12
// 45 -> 9

Console.WriteLine("введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

int Factorial(int num)
{
    if (num == 0) return num;
    return num % 10 + Factorial(num / 10);
}

int sumFac = Factorial(number);
Console.WriteLine($"Сумма числа {number} -> {sumFac} ");