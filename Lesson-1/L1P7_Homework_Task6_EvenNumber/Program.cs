Console.Write("Enter a number: ");
int num = int.Parse(Console.ReadLine());
int ost = num % 2;
if (ost == 0) Console.WriteLine(num + " -> yes");
else Console.WriteLine(num + " -> no");