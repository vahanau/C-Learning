using System;

using static System.Console;

Clear();
Write("Введие день недели: ");

int number = int.Parse(ReadLine());

if((number<1)||(number > 7))
{
    WriteLine("Введен не верный день недели");
    return;
}
if(number>5)
{
    WriteLine("Выходной");
}
else
{
    WriteLine("Не выходной");
}