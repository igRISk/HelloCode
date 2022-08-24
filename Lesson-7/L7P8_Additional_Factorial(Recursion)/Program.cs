// Рекурсия: найти факториал числа

Console.Write("Please enter a number: ");
int num = int.Parse(Console.ReadLine());

Console.WriteLine(num + " -> " + Factorial(num));

int Factorial(int number)
{
    if (number == 1)
        return number;
    return number * Factorial(number - 1);
}