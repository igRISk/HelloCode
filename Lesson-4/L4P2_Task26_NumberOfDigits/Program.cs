// Задача 26: Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
// 456 -> 3
// 78 -> 2
// 89126 -> 5 

Console.Write("Enter a number: ");
int num = int.Parse(Console.ReadLine());
int i=0;

Console.Write(num + " -> ");

while (num > 1)
{
    num = num / 10;
    i++;
}

Console.Write(i);