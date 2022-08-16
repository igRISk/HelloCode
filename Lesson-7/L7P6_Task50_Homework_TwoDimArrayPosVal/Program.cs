// Задача 50: Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.

// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет
// {1, 2} -> 2


Console.Write("Enter the number of rows in the array: ");
int row = int.Parse(Console.ReadLine());
Console.Write("Enter the number of columns in the array: ");
int col = int.Parse(Console.ReadLine());

int[,] numbers = new int[row, col];
int numFrom = 1;
int numTo = 10;

Console.Write("Enter a number from " + numFrom + " to " + numTo + ": ");
int inputValue = int.Parse(Console.ReadLine());
Console.Write("Enter the position of the number you are looking for in array(two nums separated by a space): ");
int[] inputPosition = Console.ReadLine().Split().Select(int.Parse).ToArray();

FillArray(numbers, numFrom, numTo);
PrintArray(numbers);
Console.WriteLine();
int[] outPosition = SearchNumberInArray(numbers, inputValue);
int[] outValuePosition = ValueOfPositionInArray(numbers, inputPosition);

if (outPosition[0] == 1)
    Console.WriteLine(inputValue + " -> { " + outPosition[1] + ", " + outPosition[2] + " }");
else
    Console.WriteLine(inputValue + " -> the number you are looking for is not in this array");

if (outValuePosition[0] == 1)
    Console.WriteLine("{ " + inputPosition[0] + ", " + inputPosition[1] + " } -> " + outValuePosition[1]);
else
    Console.WriteLine("{ " + inputPosition[0] + ", " + inputPosition[1] + " } -> " + "there is no such position in this array");


int[] SearchNumberInArray(int[,] array, int value)
{
    int[] outPosition = {0 , 0, 0};    
    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)
            if (value == array[i, j])
            {
                outPosition[0] = 1;
                outPosition[1] = i;
                outPosition[2] = j;
                return outPosition;
            }
    return outPosition;
}

int[] ValueOfPositionInArray(int[,] array, int[] position)
{
    int[] outValue = {0 , 0};
    if (position[0] < array.GetLength(0) && position[1] < array.GetLength(1))
    {
        outValue[0] = 1;
        outValue[1] = array[position[0], position[1]];
    }
    return outValue;
}

void FillArray(int[,] array, int from, int to)
{
    Random random = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)
            array[i,j] = random.Next(from, to);
}

void PrintArray(int[,] array)
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