// Задача 58: Задайте две матрицы. Напишите программу, 
// которая будет находить произведение двух матриц.

Console.WriteLine();
Console.Write("Enter the number of rows and columns separated by a space: ");
string[] arraySize = Console.ReadLine().Split();
int row = int.Parse(arraySize[0]);
int col = int.Parse(arraySize[1]);

int[,] numbers1 = new int[row, col];
int[,] numbers2 = new int[col, row];
int numFrom = 1;
int numTo = 5;

FillArray(numbers1, numFrom, numTo);
FillArray(numbers2, numFrom, numTo);
PrintArray(numbers1);
PrintArray(numbers2);
int[,] matrixProduct = MartixMultiplication(numbers1, numbers2);
PrintArray(matrixProduct);



int[,] MartixMultiplication(int[,] matrix1, int[,] matrix2)
{
    int rows = matrix1.GetLength(0);
    int columns = matrix2.GetLength(1);
    int[,] multipliedMatrix = new int[rows, columns];
    for (int i = 0; i < rows; i++)
        for (int j = 0; j < columns; j++)
            for (int k = 0; k < matrix2.GetLength(0); k++)
                multipliedMatrix[i, j] += matrix1[i, k] * matrix2[k, j];
    return multipliedMatrix;
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