Console.Write("Enter 'X' coordinate for point A: ");
int xA = int.Parse(Console.ReadLine());
Console.Write("Enter 'Y' coordinate for point A: ");
int yA = int.Parse(Console.ReadLine());
Console.Write("Enter 'X' coordinate for point B: ");
int xB = int.Parse(Console.ReadLine());
Console.Write("Enter 'Y' coordinate for point B: ");
int yB = int.Parse(Console.ReadLine());

double result = getDistance(xA, yA, xB, yB);
Console.WriteLine("Distance between points A and B = " + Math.Round(result, 2));


double getDistance (int x1, int y1, int x2, int y2)
{
    double distance = Math.Sqrt((x1-x2)*(x1-x2)+(y2-y1)*(y2-y1));
    return distance;
}