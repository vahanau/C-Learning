using System;

Console.Clear();

Console.Write("Введите число N: ");
int N = int.Parse(Console.ReadLine());
int i = 1;

while (i <= N)
{
    if (i % 2 == 0)
    {
        Console.Write($"{i} ");
    }
    i++;
}
System.Console.WriteLine();
int k = 2;
while (k <= N)
{
    Console.Write($"{k} ");
    k += 2;
}