// 3. Напишите программу, которая будет
// выдавать название дня недели по заданнаму номеру.

Console.Write("Введите номер дня недели: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number == 1)
{
    Console.WriteLine("Понедельник");
}
if (number == 2)
{
    Console.WriteLine("Вторник");
}
if (number == 3)
{
    Console.WriteLine("Среда");
}
if (number == 4)
{
    Console.WriteLine("Четверг");
}
if (number == 5)
{
    Console.WriteLine("Пятница");
}
if (number == 6)
{
    Console.WriteLine("Суббота");
}
if (number == 7)
{
    Console.WriteLine("Воскресенье");
}
if (number > 8)
{
    Console.WriteLine("Упс! В неделе только 7 дней");
}