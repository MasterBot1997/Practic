// Задача 24: Напишите программу, которая
// принимает на вход число (А) и выдаёт сумму чисел
// от 1 до А.
// 7 -> 28
// 4 -> 10
// 8 -> 36

Console.Write("введите число А = ");
int num = Convert.ToInt32(Console.ReadLine());

int SumNumbers(int number)
{
    int sum = default;
    for (int i = 1; i <= number; i++)
    {
        // sum = sum + 1;
        sum += i;
    }
    return sum;
}

// int result = SumNumbers(num);
// Console.WriteLine($"сумма числа А = {result}");
int sumNumbers = SumNumbers(num);
Console.WriteLine(sumNumbers);