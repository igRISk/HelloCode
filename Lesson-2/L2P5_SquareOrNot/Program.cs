// Напишите программу, которая принимает на вход два числа и проверяет, является ли одно число квадратом другого.
// 5, 25  ->  да
// -4, 16  ->  да
// 25, 5  ->  да
// 8,9  ->  нет

Console.Write("Enter number 1: ");
int num1 = int.Parse(Console.ReadLine());
Console.Write("Enter number 2: ");
int num2 = int.Parse(Console.ReadLine());

bool isSqr(int a, int b)
{
    if ((a * a) == b || (b * b) == a)
        return true;
    else
        return false;
}

if (isSqr(num1, num2))
    Console.WriteLine(num1 + ", " + num2 + " -> yes");
else
    Console.WriteLine(num1 + ", " + num2 + " -> no");