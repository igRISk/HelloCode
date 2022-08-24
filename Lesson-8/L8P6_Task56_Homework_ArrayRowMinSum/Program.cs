// Задача 56: Задайте прямоугольный двумерный массив. Напишите
// программу, которая будет находить строку с наименьшей суммой элементов.

Console.WriteLine();
Console.Write("Enter the number of rows and columns separated by a space: ");
string[] arraySize = Console.ReadLine().Split();
int row = int.Parse(arraySize[0]);
int col = int.Parse(arraySize[1]);

int[,] numbers = new int[row, col];
int numFrom = 1;
int numTo = 3;

FillArray(numbers, numFrom, numTo);
PrintArray(numbers);
PrintRowsWithSmallestSum(numbers);



void PrintRowsWithSmallestSum(int[,] array)
{
    int[] rowsSum = new int[array.GetLength(1)];
    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)
            rowsSum[i] += array[i, j];

    int minRowValue = rowsSum[0];
    int minRowIndex = 0;
    for (int i = 0; i < rowsSum.Length; i++)
        if (rowsSum[i] < minRowValue)
        {
            minRowValue = rowsSum[i];
            minRowIndex = i;
        }
    Console.WriteLine($"minRowValue = {minRowValue}");
    Console.WriteLine();

    for (int i = 0; i < rowsSum.Length; i++)
        if (rowsSum[i] == minRowValue)
        {
            minRowIndex = i;
            for (int j = 0; j < array.GetLength(1); j++)
            {
                if (j == array.GetLength(1) - 1)
                    Console.Write(array[i, j]);
                else
                    Console.Write(array[i, j] + ",\t");
            }
            Console.WriteLine();
        }
    Console.WriteLine();
}

void FillArray(int[,] array, int randomFrom, int randomTo)
{
    Random random = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)
            array[i, j] = random.Next(randomFrom, randomTo);
}

void PrintArray(int[,] array)
{
    Console.WriteLine();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (j == array.GetLength(1) - 1)
                Console.Write(array[i, j]);
            else
                Console.Write(array[i, j] + ",\t");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}