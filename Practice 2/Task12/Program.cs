﻿using System;
using static System.Console;

Clear();

Write("Введите первое число: ");
int a=int.Parse(ReadLine());
Write("Введите второе число: ");
int b=int.Parse(ReadLine());

if(a%b==0)
{
    WriteLine("Кратно");
}
else
{
    WriteLine($"Не кратно {a%b}");
}