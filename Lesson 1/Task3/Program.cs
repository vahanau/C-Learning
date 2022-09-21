using System;

Console.Clear();
Console.Write("Введите число N: ");
int N=int.Parse(System.Console.ReadLine());
int B=-N;
while(B<=N)
{
    Console.Write($"{B}: ");
    B++;
}
