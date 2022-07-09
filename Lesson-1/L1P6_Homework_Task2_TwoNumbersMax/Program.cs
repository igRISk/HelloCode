Console.Write("Enter number 1: ");
int num1 = int.Parse(Console.ReadLine());
Console.Write("Enter number 2: ");
int num2 = int.Parse(Console.ReadLine());
if (num1 > num2) Console.Write("a = "+ num1 + "; b = " + num2 + " -> max = " + num1);
else Console.Write("a = "+ num1 + "; b = " + num2 + " -> max = " + num2);