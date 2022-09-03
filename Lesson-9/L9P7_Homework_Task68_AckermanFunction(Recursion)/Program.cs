// Задача 68: Напишите программу вычисления функции Аккермана с помощью
// рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 29

Console.Clear();
Console.WriteLine();

Console.Write("Please, enter M: ");
int m = int.Parse(Console.ReadLine());
if (m < 0) 
    while (m < 0) 
    {
        Console.Write("M should be > 0, please, enter a valid value: ");
        m = int.Parse(Console.ReadLine());
    }

Console.Write("Please, enter N: ");
int n = int.Parse(Console.ReadLine());
if (n < 0) 
    while (n < 0) 
    {
        Console.Write("N should be > 0, please, enter a valid value: ");
        m = int.Parse(Console.ReadLine());
    }

int resultAF = AckermanFunction(m, n);
Console.WriteLine();
Console.WriteLine($"m = {m}, n = {n} -> A({m},{n}) = {resultAF}");
Console.WriteLine();



int AckermanFunction(int mm, int nn)
{
    if (mm == 0) return nn + 1;
    if (mm > 0 && nn == 0) return AckermanFunction(mm - 1 , 1);
    else return AckermanFunction(mm - 1, AckermanFunction(mm, nn - 1));
}