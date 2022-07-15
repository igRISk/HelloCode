// Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23.
// 14 -> нет 
// 46 -> нет 
// 161 -> да

// if (num % 7 == 0 && num % 23 == 0)
//     Console.WriteLine(num + " -> yes");
// else
//    Console.WriteLine(num + " -> no");

Console.Write("Enter a number: ");
int num = int.Parse(Console.ReadLine());

void KratnoeChislo(int number)
{
    if (number % 7 == 0 && number % 23 == 0)
    {
        Console.WriteLine("Number " + number + " is multiple to 7 and 23");
    }
    else
    {
        Console.WriteLine("Number " + number + " is not multiple to 7 and 23");
    }
}

KratnoeChislo(num);