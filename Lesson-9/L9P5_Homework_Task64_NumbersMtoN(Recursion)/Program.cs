// Задача 64: Задайте значения M и N. Напишите программу, которая выведет все
// натуральные числа в промежутке от M до N.
// M = 4; N = 8 -> "4, 6, 7, 8"

Console.Clear();
Console.WriteLine();

Console.Write("Enter M: ");
int m = int.Parse(Console.ReadLine());
Console.Write("Enter N: ");
int n = int.Parse(Console.ReadLine());

Console.Write($"M = {m}; N = {n} -> ");
NumbersMtoN(m, n);

Console.WriteLine();
Console.Write($"M = {m}; N = {n} -> ");
Console.WriteLine(NumbersMtoNstr(m, n));



void NumbersMtoN(int fromM, int toN)
{
    if (fromM > toN) return; 
    Console.Write(fromM + " ");
    NumbersMtoN(fromM + 1, toN);
}

string NumbersMtoNstr (int fromM, int toN)
{
    if (fromM < toN) return $"{fromM} " + NumbersMtoNstr(fromM + 1, toN);
    else return $"{toN}";
}