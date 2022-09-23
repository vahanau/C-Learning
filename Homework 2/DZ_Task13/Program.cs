using System;

using static System.Console;

Clear();

WriteLine("Введите число: ");
int number = int.Parse(ReadLine());

if (number < 100)
{
    WriteLine("Третьей цифры нет!");
    return;
}

int a = (number / 100) / 10;
WriteLine($"Третья цифра числа {number}->{a}");