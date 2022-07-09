// Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
// 
// 4 -> да
// -3 -> нет
// 7 -> нет

Console.Write("Enter a number: ");
int num = int.Parse(Console.ReadLine());
int ost = num % 2;
if (ost == 0) Console.WriteLine(num + " -> yes");
else Console.WriteLine(num + " -> no");