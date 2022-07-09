Console.Write("Please enter three-digit number: ");
int num = int.Parse(Console.ReadLine());

Console.WriteLine("Last number = " + num % 10);
Console.WriteLine("Second number = " + num % 100 / 10);