// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму 
// натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.Clear();
Console.WriteLine();
Console.Write("Please, enter M: ");
int m = int.Parse(Console.ReadLine());
Console.Write("Please, enter N: ");
int n = int.Parse(Console.ReadLine());

int sumNatMtoN = SumNaturals(m, n);
Console.WriteLine($"M = {m}; N = {n} -> {sumNatMtoN}");



int SumNaturals (int fromNum, int toNum)
{
    if (fromNum > toNum) return 0;
    else return SumNaturals(fromNum + 1, toNum) + fromNum;
}