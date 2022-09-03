// Задача 67: Напишите программу, которая будет принимать на вход число и возвращать сумму его цифр.
// 453 -> 12
// 45 -> 9

Console.Clear();
Console.Write("Enter a number: ");
int num = int.Parse(Console.ReadLine());
int sum = 0;

Console.Write(num);
SumDigits(num);
Console.WriteLine($"{num} -> {SumDigitsRec(num)}");



void SumDigits (int number)
{
    int sumDig = 0;
    while (number > 0)
    {
        sumDig += number % 10;
        number /= 10;
    }
    Console.WriteLine($" -> {sumDig}");
}

int SumDigitsRec (int number)
{
    if (number < 10) return number;
    else return (num % 10) + SumDigitsRec(num/10);
}
