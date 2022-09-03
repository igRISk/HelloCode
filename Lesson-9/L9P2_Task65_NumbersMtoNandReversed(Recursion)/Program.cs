// Задача 65: Задайте значения M и N. Напишите программу, которая
// выведет все натуральные числа в промежутке от M до N.
// M = 4; N = 8 -> "4, 6, 7, 8"

Console.WriteLine();
Console.Write("Please enter number from: ");
int fromNum = int.Parse(Console.ReadLine());
Console.Write("Please enter number to: ");
int toNum = int.Parse(Console.ReadLine());

Console.Write($"M = {fromNum}; N = {toNum} -> ");
Console.WriteLine(GetNumbers(fromNum, toNum));
Console.WriteLine();

GetNumbersReversedTo0(toNum);
Console.WriteLine();
Console.WriteLine(GetNumbersReversed(toNum, ""));



string GetNumbers(int numberFrom, int numberTo)
{
    if (numberFrom < numberTo) return $"{numberFrom} " + GetNumbers(numberFrom + 1, numberTo);
    else return $"{numberTo}";
}

void GetNumbersReversedTo0(int numberTo)
{
    if (numberTo == 0) return;
    Console.Write(numberTo + "\t");
    numberTo--;
    GetNumbersReversedTo0(numberTo);
}

string GetNumbersReversed(int numberTo, string res)
{
    if (numberTo == 0) return res;
    return ($"{numberTo}\t{GetNumbersReversed(--numberTo, res)} ");
}