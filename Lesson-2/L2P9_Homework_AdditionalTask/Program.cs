// Дополнительное задание: Напишите программу, которая принимает на вход число N и выводит все простые числа 
// в промежутке от 0 до N (включительно). После, попробуйте поэксперментировать с величиной значения N и понаблюдать 
// за тем, как оно влияет на время выполнения программы. 

Console.Write("Enter a number: ");
int num = int.Parse(Console.ReadLine());

Console.Write("Prime numbers in between 0 and " + num + " -> ");

int i = 2;

while (i <= num)
{
    int c = 2;
    bool PrimeNum = true;
    while (c < Math.Sqrt(i)) 
    {
        if (i % c == 0)
            PrimeNum = false;
        c++;
    }
    if (PrimeNum)    
        Console.Write(i + " ");
    i++;
}