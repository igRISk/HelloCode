// Задача 47: Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9


Console.Write("Enter the number of rows and columns separated by a space: ");
string[] arraySize = Console.ReadLine().Split();
int row = int.Parse(arraySize[0]);
int col = int.Parse(arraySize[1]);

float[,] numbers = new float[row, col];
int numFrom = -10;
int numTo = 10;

Console.WriteLine();
FillArray(numbers, numFrom, numTo);
PrintArray(numbers);



void FillArray(float[,] array, int randomFrom, int randomTo)
{
    Random rnd = new Random();
    double rrange = randomTo - randomFrom;
    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)
        {
            double sample = rnd.NextDouble();
            double scaled = (sample * rrange) + randomFrom;
            array[i, j] = (float)scaled;
        }
}

void PrintArray(float[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (j == array.GetLength(1) - 1)
                Console.Write($"{array[i, j],0:f2}");
            else
                Console.Write($"{array[i, j],0:f2}\t");
        }
    Console.WriteLine();
    }
}