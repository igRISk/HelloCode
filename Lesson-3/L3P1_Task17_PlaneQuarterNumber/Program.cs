// Напишите программу, которая принимает на вход координаты точки (X и Y), причём X ≠ 0 и Y ≠ 0 
// и выдаёт номер четверти плоскости, в которой находится эта точка.

//      ^ (y)
//      |
//   2  |  1 
//      |
// -----------> (x)
//      |
//   3  |  4 
//      |

Console.Write("Enter 'X' coordinate (not 0): ");
int xIn = int.Parse(Console.ReadLine());
Console.Write("Enter 'Y' coordinate (not 0): ");
int yIn = int.Parse(Console.ReadLine());

int result = getQuarter(xIn, yIn);

if (result > 0)
    Console.WriteLine ("Your quarter number is: " + result);
else
    Console.WriteLine ("Coordinates can't be equal to 0");


int getQuarter(int x, int y)
{
    if (x > 0 && y > 0)
        return 1;
    if (x < 0 && y > 0)
        return 2;
    if (x < 0 && y < 0)
        return 3;
    if (x > 0 && y < 0)
        return 4;
    else
        return -1;
}