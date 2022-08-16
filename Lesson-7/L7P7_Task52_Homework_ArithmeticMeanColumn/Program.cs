// Задача 52: Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

Console.Write("Enter the number of rows and columns separated by a space: ");
string[] arraySize = Console.ReadLine().Split();
int row = int.Parse(arraySize[0]);
int col = int.Parse(arraySize[1]);

int[,] numbers = new int[row, col];
int numFrom = 1;
int numTo = 10;

FillArray(numbers, numFrom, numTo);
PrintTwoDimArray(numbers);

PrintArray(GetArithmeticMeanColumns(numbers));



float[] GetArithmeticMeanColumns (int[,] array)
{
    int columns = array.GetLength(1);
    float[] arithmeticMean = new float[columns];
    for (int j = 0; j < array.GetLength(1); j++)
    {
        for (int i = 0; i < array.GetLength(0); i++)
            arithmeticMean[j] += array[i, j];
        arithmeticMean[j] = arithmeticMean[j] / columns;
    }
    return arithmeticMean;
}

void FillArray (int[,] array, int from, int to)
{
    Random rnd = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)
            array[i,j] = rnd.Next(from, to);
}

void PrintArray (float[] array)
{
    int length = array.Length;
    Console.Write("The arithmetic mean of the elements in each column: { ");
    for (int index = 0; index < length; index++)
    {
        if (index < length -1) Console.Write(array[index] + " ");
        else Console.Write(array[index] + " ");
    }
    Console.Write("}");
    Console.WriteLine();
}

void PrintTwoDimArray (int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            if (j == array.GetLength(1) - 1) 
                Console.Write(array[i,j]);
            else
                Console.Write(array[i,j] + ", ");
    Console.WriteLine();
    }
}