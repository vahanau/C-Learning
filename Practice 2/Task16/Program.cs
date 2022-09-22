using System;
using static System.Console;

Clear();

Write("Введите число A: ");
int A = int.Parse(ReadLine());

Write("Введите число B: ");
int B = int.Parse(ReadLine());

if (B * B == A)
{
    WriteLine("A является квадратом B");
}
else
{
    if (Math.Pow(A, 2) == B)
    {
        WriteLine("B является квадратом A");
    }
    else
    {
        WriteLine("Не является");
    }
}