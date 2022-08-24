// Задача 62: Заполните спирально массив 4 на 4.

Console.WriteLine();
Console.Write("Enter the number of rows and columns separated by a space: ");
string[] arraySize = Console.ReadLine().Split();
int row = int.Parse(arraySize[0]);
int col = int.Parse(arraySize[1]);

int[,] numbers = new int[row, col];

FillArraySpiral(numbers);
PrintArray(numbers);



void FillArraySpiral(int[,] array)
{
    int i = 0, j = 0;
    int rows = array.GetLength(0);
    int cols = array.GetLength(1);
    int iBegin = 0, iFinal = 0, jBegin = 0, jFinal = 0;

    for (int m = 1; m <= rows * cols; m++)
    {
        array[i, j] = m;
        if (i == iBegin && j < cols - jFinal - 1)
            j++;
        else if (j == cols - jFinal - 1 && i < rows - iFinal - 1)
            i++;
        else if (i == rows - iFinal - 1 && j > jBegin)
            j--;
        else
            i--;

        if ((i == iBegin + 1) && (j == jBegin) && (jBegin != cols - jFinal - 1))
        {
            iBegin++;
            iFinal++;
            jBegin++;
            jFinal++;
        }
    }
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