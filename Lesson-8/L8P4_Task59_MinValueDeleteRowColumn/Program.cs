// Задача 59: Задайте двумерный массив из целых чисел.
// Напишите программу, которая удалит строку и столбец, на пересечении которых 
// расположен наименьший элемент массива.

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
int[,] numbersResult = DeleteRowAndColumnWithMinValue(numbers);
Console.WriteLine();
PrintArray(numbersResult);



int[,] DeleteRowAndColumnWithMinValue(int[,] array)
{
    int minValue = array[0, 0];
    int[] minValueIndex = new int[2];
    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)
            if (array[i, j] < minValue)
            {
                minValue = array[i, j];
                minValueIndex[0] = i;
                minValueIndex[1] = j;
            }

    Console.WriteLine("minValue ["+ minValueIndex[0] + ", "+ minValueIndex[1] + "] = " + minValue);

    int[,] truncatedArray = new int[array.GetLength(0) - 1, array.GetLength(1) - 1];
    int rows = 0, columns = 0;
    if (minValueIndex[0] == array.GetLength(0) - 1)
        rows = array.GetLength(0) - 1;
    else
        rows = array.GetLength(0);
    if (minValueIndex[1] == array.GetLength(1) - 1) 
        columns = array.GetLength(1) - 1;
    else
        columns = array.GetLength(1);

    for (int i = 0, k = 0; i < rows; i++, k++)
    {
        if (i == minValueIndex[0]) i++;
        for (int j = 0, l = 0; j < columns; j++, l++)
        {
            if (j == minValueIndex[1]) j++;
            truncatedArray[k, l] = array[i, j];
        }
    }
    return truncatedArray;
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