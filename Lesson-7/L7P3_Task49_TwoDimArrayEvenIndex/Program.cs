// Задача 49: Задайте двумерный массив. Найдите элементы, у которых оба индекса чётные, 
// и замените эти элементы на их квадраты.

Console.Write("Enter the number of rows and columns separated by a space: ");
string[] input = Console.ReadLine().Split();
int row = int.Parse(input[0]);
int col = int.Parse(input[1]);

int[,] numbers = new int[row, col];
int numFrom = 1;
int numTo = 10;

FillArray(numbers, numFrom, numTo);
PrintArray(numbers);
Console.WriteLine();
MakeSquareEvenIndex(numbers);
PrintArray(numbers);



void MakeSquareEvenIndex (int[,] array)
{
     for (int i = 2; i < array.GetLength(0); i++)
        for (int j = 2; j < array.GetLength(1); j++)
            if (i % 2 == 0 && j % 2 == 0)
                array[i, j] *= array [i, j]; 
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