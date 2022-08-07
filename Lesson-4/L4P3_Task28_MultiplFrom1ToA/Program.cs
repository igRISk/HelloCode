Console.Write("Enter a number: ");
int num = int.Parse(Console.ReadLine());
int res = 1;

Console.Write(num + " -> " + Multiply(num));



int Multiply (int n)
{
    for (int i = 2; i <= n; i++)
    {
    res = res * i;
    }
    return res;
}