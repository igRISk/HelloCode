// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.Write("Enter a number: ");
int num = int.Parse(Console.ReadLine());
int sum = 0;

Console.Write(num);

while (num > 0)
{
    sum = sum + num % 10;
    num = num / 10;
}

Console.Write(" -> " + sum);