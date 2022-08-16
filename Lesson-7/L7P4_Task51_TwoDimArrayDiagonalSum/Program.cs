// Задача 51: Задайте двумерный массив. 
// Найдите сумму элементов главной диагонали.

Console.Write("Enter the number of rows and columns separated by a space: ");
string[] arraySize = Console.ReadLine().Split();
int row = int.Parse(arraySize[0]);
int col = int.Parse(arraySize[1]);

int[,] numbers = new int[row, col];
int numFrom = 1;
int numTo = 10;

Console.WriteLine();
FillArray(numbers, numFrom, numTo);
PrintArray(numbers);
Console.WriteLine();
int sum = GetDiagonalSum(numbers);
Console.WriteLine("Sum of main diagonal elements = " + sum);


int GetDiagonalSum(int[,] array)
{
    int diagonalSum = 0;
    for (int i = 0, j = 0; i < array.GetLength(0) && j < array.GetLength(1); i++, j++)
        diagonalSum += array[i, j];
    return diagonalSum;
}

void FillArray(int[,] array, int randomFrom, int randomTo)
{
    Random random = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)
            array[i,j] = random.Next(randomFrom, randomTo);
}

void PrintArray(int[,] array)
{
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
}