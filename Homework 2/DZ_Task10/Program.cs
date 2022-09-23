using System;

using static System.Console;

Clear();
Write("Введите число: ");

int a1 = int.Parse(ReadLine());
int a2 = new Random().Next(100, 1000);

int b1 = (a1 / 10) % 10;
int b2 = (a2 / 10) % 10;

WriteLine($"{a1}->{b1}");
WriteLine($"{a2}->{b2}");