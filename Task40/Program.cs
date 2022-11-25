// Задача 40: Напишите программу, которая принимает на вход три
// числа и проверяет, может ли существовать треугольник с сторонами
// такой длины.
// Теорема о неравенстве треугольника: каждая сторона треугольника
// меньше суммы двух других сторон.

Console.Write("Введите первое число: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int number2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите третье число: ");
int number3 = Convert.ToInt32(Console.ReadLine());

bool InExsistTringle(int num1, int num2, int num3)
{

    bool b = num1 < num2 + num3 && num2 < num3 + num1 && num3 < num2 + num1;
    return b;
}

bool inExsistTringle = InExsistTringle(number1, number2, number3);
Console.Write(inExsistTringle);