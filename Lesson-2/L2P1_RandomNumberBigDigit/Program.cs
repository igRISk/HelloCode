int num = new Random().Next(10, 100);
Console.WriteLine("Random number: " + num);

int FirstDigit = num / 10;
int SecondDigit = num % 10;

int getMax (int a, int b)
{
    if (FirstDigit > SecondDigit)
    {
        return a;
    }
    else
    {
        return b;
    }
}

Console.WriteLine("Max number is " + getMax(FirstDigit, SecondDigit));
