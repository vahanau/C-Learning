using System;

Console.Clear();
Console.Write("Введите число: ");
int number=int.Parse(Console.ReadLine());

if(number%2==0)
{
    System.Console.WriteLine("Число четное");
}
else
{
    System.Console.WriteLine("Число не четное");
}