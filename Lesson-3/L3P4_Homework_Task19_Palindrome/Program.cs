// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.Write("Enter a number: ");
int num = int.Parse(Console.ReadLine());

if (num == flipNumber(num))
    Console.WriteLine(num + " -> yes, it's a palindrome");
else
    Console.WriteLine(num + " -> no, it's not a palindrome");



int flipNumber(int number)
{
int numInv = 0;
while (number > 0)
    {
        numInv *= 10;
        numInv += number % 10;
        number /= 10;
    }
return numInv;
}