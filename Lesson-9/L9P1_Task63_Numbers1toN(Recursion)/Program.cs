// Задача 63: Задайте значение N. Напишите программу, которая выведет
// все натуральные числа в промежутке от 1 до N.
// N = 5 -> "1, 2, 3, 4, 5"

Console.WriteLine();
Console.Write("Please enter a number: ");
int toNum = int.Parse(Console.ReadLine());
int fromNum = 1;

Console.WriteLine();
Console.Write($"N = {toNum} -> ");
NaturalNum(fromNum, toNum);



void NaturalNum(int numberFrom, int numberTo)
{
    if (numberFrom > numberTo) return;
    Console.Write(numberFrom + " ");
    NaturalNum(numberFrom + 1, numberTo);
}