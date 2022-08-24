﻿// Сумма чисел от 1 до n

Console.WriteLine(SumFor(10)); // 55
Console.WriteLine(SumRec(10)); // 55

int SumFor(int n)
{
    int result = 0;
    for (int i =0; i <= n; i++) result += i;
    return result;
}

int SumRec (int n)
{
    if (n == 0) return 0;
    else return n + SumRec(n-1);
}