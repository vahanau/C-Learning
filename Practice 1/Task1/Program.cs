using System;
Console.Clear();
Console.Write("Введите число A: ");
int A=int.Parse(Console.ReadLine());
Console.Write("Введите число B: ");
int B=int.Parse(Console.ReadLine());

if(B*B==A)
{
    Console.WriteLine("A является квадратом B");
}
else
{
    Console.WriteLine("A не является квадратом B");
}