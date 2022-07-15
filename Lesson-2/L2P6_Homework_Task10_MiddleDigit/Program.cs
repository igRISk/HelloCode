// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 
// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.Write("Enter a three-digit number: ");
int num = int.Parse(Console.ReadLine());

Console.WriteLine("Middle number is: " + num % 100 / 10);