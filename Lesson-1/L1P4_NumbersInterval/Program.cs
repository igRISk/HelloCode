Console.Write("Please enter number: ");
int num = int.Parse(Console.ReadLine());
int count = 0;

if (num > 0 ) count = count - num; 
else 
{ 
    count = num;
    num = -num;
}

while (count <= num)
{
    Console.Write(" " + count);
    count++;
}