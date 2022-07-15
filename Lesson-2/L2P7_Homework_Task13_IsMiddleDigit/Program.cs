// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.Write("Enter a number: ");
int num = int.Parse(Console.ReadLine());
string numS = num.ToString();
char[] array = numS.ToCharArray();

if (num > 99)
    Console.WriteLine(num + " -> " + array[2]);
else
    Console.WriteLine(num + " -> no third digit");