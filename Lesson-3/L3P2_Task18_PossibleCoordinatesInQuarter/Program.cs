// Напишите программу, которая по заданному номеру четверти, показывает диапазон возможных координат
// точек в этой четверти (x и y)

Console.Write("Enter number of quarter: ");
int num = int.Parse(Console.ReadLine());

Console.WriteLine("Coordinates is: " + XY(num));


string XY (int qNum)
{
    if (qNum == 1)
        return "x > 0 & y > 0";
    if (qNum == 2)
        return "x < 0 & y > 0";
    if (qNum == 3)
        return "x < 0 & y < 0";
    if (qNum == 4)
        return "x > 0 & y < 0";
    else
        return "no such quarter, enter number from 1 to 4";
}