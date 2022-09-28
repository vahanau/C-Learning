using System;
using static System.Console;

Clear();
Write("Введите координату X: ");
int X = int.Parse(ReadLine());

Write("Введите координату Y: ");
int Y = int.Parse(ReadLine());

if (X > 0 && Y > 0)
{
    WriteLine("1 четверть");
}
if (X < 0 && Y > 0)
{
    WriteLine("2 четверть");
}
if (X < 0 && Y < 0);
{
    WriteLine("3 четверть");
}
if (X > 0 && Y < 0)
{
    WriteLine("4 четверть");
}
