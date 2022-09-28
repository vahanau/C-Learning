using System;
using static System.Console;

Clear();
Write("Введите число: ");
int number = int.Parse(ReadLine());

if (number < 10000 || number > 99999)
{
    Write("Введено не пятизначное число");
    return;
}

int a1 = number / 10000;
number -= a1 * 10000;

int a2 = number / 1000;
number -= a1 * 1000;

int a3 = number / 100;
number -= a3 * 100;

int a4 = number / 10;
int a5 = number % 10;

if((a1 == a5) && (a2 == a4))
{
    WriteLine("Да");
}

else
{
    WriteLine("Нет");
}