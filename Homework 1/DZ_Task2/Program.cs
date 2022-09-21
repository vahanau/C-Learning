using System;

Console.Clear();
Console.Write("Введите первое число: ");
int A=int.Parse(Console.ReadLine());
Console.Write("Введите второе число: ");
int B=int.Parse(Console.ReadLine());

if(A>B)
{
    Console.WriteLine("Первое больше, чем второе");
}
else
{
    Console.WriteLine("Первое меньше, чем второе");
}