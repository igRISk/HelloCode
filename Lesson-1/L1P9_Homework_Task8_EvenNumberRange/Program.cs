﻿// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
// 
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

Console.Write("Enter a number: ");
int num = int.Parse(Console.ReadLine());

Console.Write(num + " -> ");

if (num % 2 != 0) num = num - 1;
int i = 2;
while (i <= num) 
{
    Console.Write(i + " ");
    i = i + 2;
}