﻿// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
// 
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

Console.Write("Enter number 1: ");
int num1 = int.Parse(Console.ReadLine());
Console.Write("Enter number 2: ");
int num2 = int.Parse(Console.ReadLine());
Console.Write("Enter number 2: ");
int num3 = int.Parse(Console.ReadLine());

int max = num1;
if (num2 > max) max = num2;
if (num3 > max) max = num3;

Console.Write("a = "+ num1 + "; b = " + num2 + "; c = " + num3 + " -> max = " + max);