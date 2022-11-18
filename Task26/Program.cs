// Задача 26: Напишите программу, 
//1. которая принимает на вход число и 
//2. выдаёт количество цифр в числе.
// 456 -> 3
// 78 -> 2
// 89126 -> 5

Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

int SumDigit(int number)
{
int k = 0;
number = Math.Abs(number);
while (number > 0)
{
    number = number / 10;
    k = k+1;
}
return k;
}

int result = SumDigit(num);
if (num == 0) Console.WriteLine($"Число {num} = 1");
else Console.WriteLine($"Число {num} состоит из {result} цифр");

