int num = new Random().Next(100, 1000);

int DelSecNum(int number)
{
int DigitOne = num / 100;
int DigitThird = num % 10;
int result = DigitOne*10 + DigitThird;
return result;
}

Console.WriteLine("Random number: " + num);
Console.WriteLine("Result is: " + DelSecNum(num));