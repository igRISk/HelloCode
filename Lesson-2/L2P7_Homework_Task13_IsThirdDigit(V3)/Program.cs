Console.Write("Enter a number: ");
int num = int.Parse(Console.ReadLine());
int num3;

if (num > 0)
    num3 = num;
else
    num3 = -num;

while (num3 > 999)
    num3 /= 10;

num3 = num3 % 10;

if (num > 99 || num < -99)
    Console.WriteLine(num + " -> " + num3);
else
    Console.WriteLine(num + " -> no third digit");