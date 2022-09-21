using System;

Console.Clear();

Console.Write("Введите первое число: ");
int A=int.Parse(Console.ReadLine());

Console.Write("Введите второе число: ");
int B=int.Parse(Console.ReadLine());

Console.Write("Введите третье число: ");
int C=int.Parse(Console.ReadLine());

if(A>B&&A>C)
{
    System.Console.WriteLine($"max{A}");
}
if(B>A&&B>C)
{
    System.Console.WriteLine($"max{B}");
}
if(C>B&&C>A)
{
    System.Console.WriteLine($"max{C}");
}