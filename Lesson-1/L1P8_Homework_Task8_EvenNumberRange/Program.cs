Console.Write("Enter a number: ");
int num = int.Parse(Console.ReadLine());

Console.Write(num + " -> ");

if (num % 2 != 0) num = num - 1;
int i = 2;
while (i <= num) 
{
    Console.Write(i + " ");
    i = i + 2;
}