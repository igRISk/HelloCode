
for (int i = 1; i < 40; i++)
    Console.WriteLine($"{i}! = {Factorial(i)}");



double Factorial (int n)
{
    if (n == 0 || n == 1) return 1;     // 0! = 1 and 1! = 1
    else return n * Factorial (n-1);
}