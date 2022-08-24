// Задача 57: Составить частотный словарь элементов двумерного массива. 
// Частотный словарь содержит информацию о том, сколько раз встречается элемент
// входных данных.

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
PrintNumberRepeatCount(numbers, numFrom, numTo);
CreateFrequencyDictionary(numbers, numFrom, numTo);
int[,] FrequencyDictionary = CreateFrequencyDictionary(numbers, numFrom, numTo);
PrintArray(FrequencyDictionary);



int[,] CreateFrequencyDictionary(int[,] array, int randomFrom, int randomTo)
{
    int rows = randomTo - randomFrom;
    int[,] numRepCount = new int[2, rows];
    for (int k = randomFrom, count = 0; k < randomTo; k++, count++)
    {
        int numRep = 0;
        for (int i = 0; i < array.GetLength(0); i++)
            for (int j = 0; j < array.GetLength(1); j++)
            {
                if (array[i, j] == k) numRep++;
            }
        numRepCount[0, count] = k;
        numRepCount[1, count] = numRep;
    }
    return numRepCount;
}

void PrintNumberRepeatCount(int[,] array, int randomFrom, int randomTo)
{
    for (int k = numFrom; k < randomTo; k++)
    {
        int numRep = 0;
        for (int i = 0; i < array.GetLength(0); i++)
            for (int j = 0; j < array.GetLength(1); j++)
            {
                if (array[i, j] == k) numRep++;
            }
        if (numRep > 0) Console.WriteLine(k + " meets " + numRep + " times");
    }
    Console.WriteLine();
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