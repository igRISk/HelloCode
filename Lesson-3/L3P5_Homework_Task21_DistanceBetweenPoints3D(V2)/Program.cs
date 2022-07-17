// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

int[] CoordA = new int[3];
int[] CoordB = new int[3];

Console.Write("Enter 'X' coordinate for point A: ");
CoordA[0] = int.Parse(Console.ReadLine());
Console.Write("Enter 'Y' coordinate for point A: ");
CoordA[1] = int.Parse(Console.ReadLine());
Console.Write("Enter 'Z' coordinate for point A: ");
CoordA[2] = int.Parse(Console.ReadLine());
Console.Write("Enter 'X' coordinate for point B: ");
CoordB[0] = int.Parse(Console.ReadLine());
Console.Write("Enter 'Y' coordinate for point B: ");
CoordB[1] = int.Parse(Console.ReadLine());
Console.Write("Enter 'Z' coordinate for point B: ");
CoordB[2] = int.Parse(Console.ReadLine());

double result = getDistance(CoordA, CoordB);
int numDec = 2;
Console.WriteLine("Distance between points A and B = " + Math.Round(result, numDec) + " (rounded to " + numDec + " decimal places)");


double getDistance (int[] arrCoordA, int[] arrCoordB)
{
    int x1 = arrCoordA[0];
    int x2 = arrCoordB[0];
    int y1 = arrCoordA[1];
    int y2 = arrCoordB[1];
    int z1 = arrCoordA[2];
    int z2 = arrCoordB[2];
    double distance = Math.Sqrt((x1-x2)*(x1-x2)+(y2-y1)*(y2-y1)+(z2-z1)*(z2-z1));
    return distance;
}