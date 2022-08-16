// Задача 48: Задайте двумерный массив размера m на n, 
// каждый элемент в массиве находится по формуле: Aₘₙ = m+n. 
// Выведите полученный массив на экран.

Console.Write("Enter the number of rows: ");
int m = int.Parse(Console.ReadLine());
Console.Write("Enter the number of columns: ");
int n = int.Parse(Console.ReadLine());

int[,] array = new int[m, n];

FillArray(array);
PrintArray(array);



void FillArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)
            array[i, j] = i + j;
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
                Console.Write(array[i, j] + ", ");
        }
    Console.WriteLine();
    }
}