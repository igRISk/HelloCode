// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

Console.Write("Enter first number: ");
int numA = int.Parse(Console.ReadLine());
Console.Write("Enter second number: ");
int numB = int.Parse(Console.ReadLine());
int res = 1;

for (int i = 1; i <= numB ; i++)
{
    res *= numA;
}

Console.Write(numA + "^" + numB + " -> " + res);