// Задача 46: Задайте двумерный массив размером m×n, заполненный случайными целыми числами.

Console.Write("Enter the number of rows in the array: ");
int row = int.Parse(Console.ReadLine());
Console.Write("Enter the number of columns in the array: ");
int col = int.Parse(Console.ReadLine());


int[,] array = new int[row, col];
int numFrom = -99;
int numTo = 100;

FillArray(array, numFrom, numTo);
PrintArray(array);



void FillArray(int[,] matrix, int from, int to)
{
    Random random = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
        for (int j = 0; j < matrix.GetLength(1); j++)
            matrix[i,j] = random.Next(from, to);
}

void PrintArray(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
            if (j == matrix.GetLength(1) - 1) 
                Console.Write(matrix[i,j]);
            else
                Console.Write(matrix[i,j] + ", ");
    Console.WriteLine();
    }
}