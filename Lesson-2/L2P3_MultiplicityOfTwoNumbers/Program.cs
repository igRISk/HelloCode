﻿// Напишите программу, которая будет принимать на вход два числа и выводить, является ли второе число кратным первому. 
// Если число 2 не кратно числу 1, то программа выводит остаток от деления.
// 34, 5 -> не кратно, остаток 4 
// 16, 4 -> кратно

Console.Write("Enter number 1: ");
int num1 = int.Parse(Console.ReadLine());
Console.Write("Enter number 2: ");
int num2 = int.Parse(Console.ReadLine());

if (num2 % num1 == 0)
    Console.WriteLine(num2 + ", " + num1 + " -> multiple");
else
    Console.WriteLine(num2 + ", " + num1 + " -> not multiple, remainder of the division " + (num2 % num1));