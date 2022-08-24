// Задача 54: Задайте двумерный массив. Напишите программу, которая
// упорядочит по убыванию элементы каждой строки двумерного массива.

Console.WriteLine();
Console.Write("Enter the number of rows and columns separated by a space: ");
string[] arraySize = Console.ReadLine().Split();
int row = int.Parse(arraySize[0]);
int col = int.Parse(arraySize[1]);

int[,] numbers = new int[row, col];
int numFrom = 1;
int numTo = 10;

FillArray(numbers, numFrom, numTo);
PrintArray(numbers);
GetArrayDescendingSortedRows(numbers);
PrintArray(numbers);



void GetArrayDescendingSortedRows(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1) - 1; j++)
        {
            int maxPosition = j;
            for (int k = j + 1; k < array.GetLength(1); k++)
                if (array[i, k] > array[i, maxPosition])
                    maxPosition = k;
            int temporary = array[i, j];
            array[i, j] = array[i, maxPosition];
            array[i, maxPosition] = temporary;
        }
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