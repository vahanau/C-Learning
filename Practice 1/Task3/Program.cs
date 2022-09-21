using System;
Console.Clear();
Console.Write("Вывести номер дня недели: ");
int number=int.Parse(Console.ReadLine());
if(number==1)
{
System.Console.WriteLine("Понедельник");
}
if(number==2)
{
System.Console.WriteLine("Вторник");
}
if(number==3)
{
System.Console.WriteLine("Среда");
}
if(number==4)
{
System.Console.WriteLine("Четверг");
}
if(number==5)
{
System.Console.WriteLine("Пятница");
}
if(number==6)
{
System.Console.WriteLine("Суббота");
}
if(number==7)
{
System.Console.WriteLine("Воскресенье");
}
if(number>7||number<1)
{
    System.Console.WriteLine("Ошибка, такого дня нет");
}