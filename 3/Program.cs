﻿// Напишите программа,кот.б.выдавать название недели по заданному номеру (3->среда, 5->пятница)


Console.Clear();
Console.Write("Введите номер дня недели: ");
int numberDayOfWeek = int.Parse(Console.ReadLine());
if (numberDayOfWeek < 1 || numberDayOfWeek > 7)
{
    Console.WriteLine("Введён неправильный номер");
    return;
}

if (numberDayOfWeek == 1)
{
    Console.WriteLine("Понедельник");
}
if (numberDayOfWeek == 2)
{
    Console.WriteLine("Вторник");
}
if (numberDayOfWeek == 3)
{
    Console.WriteLine("Среда");
}
if (numberDayOfWeek == 4)
{
    Console.WriteLine("Четверг");
}
if (numberDayOfWeek == 5)
{
    Console.WriteLine("Пятница");
}
if (numberDayOfWeek == 6)
{
    Console.WriteLine("Суббота");
}
if (numberDayOfWeek == 7)
{
    Console.WriteLine("Воскресенье");
}