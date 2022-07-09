string res = "no";
Console.Write("Enter number 1: ");
int num1 = int.Parse(Console.ReadLine());
Console.Write("Enter number 2: ");
int num2 = int.Parse(Console.ReadLine());
if ((num1 * num1) == num2 || (num2 * num2) == num1) res = "yes"; 
Console.Write ("a = " + num1 + " b = " + num2 + " -> " + res);