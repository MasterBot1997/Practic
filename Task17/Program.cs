// 17.  Напишите программу которая принимает
// 1. на вход координаты точки (X и Y), причем X не равен 0 и Y yt hfdty 0 и
// 2. выдвет номер четверти плоскости, в которой находится эта точка.

Console.WriteLine("Введите координаты точки");
Console.Write("x: ");
int x = Convert.ToInt32(Console.ReadLine());
Console.Write("y: ");
int y = Convert.ToInt32(Console.ReadLine());

int Quarter(int xc, int yc)
{
    if (xc > 0 && yc > 0) return 1;
    if (xc < 0 && yc > 0) return 2;
    if (xc < 0 && yc < 0) return 3;
    if (xc > 0 && yc < 0) return 4;
    return 0;
}

int quarter = Quarter(x, y);
string result = quarter > 0
                ? $"указанные координаты соответствуют четверти -> ({quarter})" 
                : "Введены некорректные координаты";
Console.WriteLine(result);

