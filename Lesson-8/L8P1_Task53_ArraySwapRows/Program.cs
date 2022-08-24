// Задача 53: Задайте двумерный массив. Напишите программу, которая поменяет местами 
// первую и последнюю строку массива.

Console.WriteLine();
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
SwapRows(numbers);
PrintArray(numbers);



void SwapRows(int[,] array)
{
    int rows = array.GetLength(0);
    int columns = array.GetLength(1);
    int tmp = 0;
    for (int i = 0; i < columns; i++)
    {
        tmp = array [0, i];
        array [0, i] = array [rows - 1, i];
        array [rows - 1, i] = tmp;
    }
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
    Console.WriteLine();
}