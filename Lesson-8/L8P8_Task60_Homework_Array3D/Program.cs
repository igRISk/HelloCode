/* Задача 60: Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента. */

Console.WriteLine();
Console.Write("Enter 3 numbers separated by a space: ");
string[] arraySize = Console.ReadLine().Split();
int row = int.Parse(arraySize[0]);
int col = int.Parse(arraySize[1]);
int depth = int.Parse(arraySize[2]);

int[,,] array3d = new int[row, col, depth];
int numFrom = 10;
FillArray3d(array3d, numFrom);
PrintArray3d(array3d);



void FillArray3d(int[,,] array, int numberFrom)
{
    int count = numberFrom;
    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)
            for (int k = 0; k < array.GetLength(2); k++)
                {
                    array[i, j, k] = numberFrom;
                    numberFrom++;
                }
}

void PrintArray3d(int[,,] array)
{
    Console.WriteLine();
    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)
            for (int k = 0; k < array.GetLength(2); k++)
                Console.WriteLine($"[{i} ,{j}, {k}] {array[i, j, k]}");
    Console.WriteLine();
}