// Задача 69: Напишите программу, которая на вход принимает два числа A и B, и
// возводит число А в целую степень B с помощью рекурсии.
// A = 3; B = 5 -> 243 (3⁵)

Console.Clear();
Console.WriteLine();
Console.Write("Enter number A: ");
int a = int.Parse(Console.ReadLine());
Console.Write("Enter number B: ");
int b = int.Parse(Console.ReadLine());

Console.WriteLine($"A = {a}; B = {b} -> {Power(a, b)}");



double Power(int n, int p)
{
    if (p == 1) return n;
    if (p == 0) return 1;
    if (p < 0) return 1/Power(n, -p);
    return n*Power(n, --p);
}