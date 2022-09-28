using System;
using static System.Console;

Clear();
Write("Введите X1: ");
int x1 = int.Parse(ReadLine());
Write("Введите Y1: ");
int y1 = int.Parse(ReadLine());
Write("Введите X2: ");
int x2 = int.Parse(ReadLine());
Write("Введите Y2: ");
int y2 = int.Parse(ReadLine());

double d = Math.Sqrt(Math.Pow(x1 - x2, 2) + Math.Pow(y1 - y2, 2));

WriteLine($"Длина отрезка = {d:f3} ");
