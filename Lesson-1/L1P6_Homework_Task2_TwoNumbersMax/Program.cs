// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт максимальное из этих чисел.

// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

Console.Write("Enter number 1: ");
int num1 = int.Parse(Console.ReadLine());
Console.Write("Enter number 2: ");
int num2 = int.Parse(Console.ReadLine());
if (num1 > num2) Console.Write("a = "+ num1 + "; b = " + num2 + " -> max = " + num1);
else Console.Write("a = "+ num1 + "; b = " + num2 + " -> max = " + num2);