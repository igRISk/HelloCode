﻿// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет

Console.Write("Enter a number: ");
int num = int.Parse(Console.ReadLine());

if (num >= 1 && num <=5)
        Console.WriteLine(num + " -> no");
else if (num == 6 || num ==7)
        Console.WriteLine(num + " -> yes");
else
        Console.WriteLine(num + " -> no such day of the week");