/* Задача 35: Задайте одномерный массив из 123 случайных чисел. Найдите количество элементов массива, 
значения которых лежат вотрезке [10,99].
[5, 18, 123, 6, 2] -> 1
[1, 2, 3, 6, 2] -> 0
[10, 11, 12, 13, 14] -> 5 */

Console.Write("Enter size of array: ");
int size = int.Parse(Console.ReadLine());
int[] array = new int[size];

FillArray(array);
PrintArray(array);

int numelem = 0;

for (int i = 0; i < size; i++)
{
    if (array[i] > 9 && array[i] < 100) 
        numelem ++;
}

Console.Write("Number of elements in array beetwen 10 and 99 = " + numelem);



void FillArray(int[] arr)
{
    int length = arr.Length;
    for (int index = 0; index < length; index++)
    {
        arr[index] = new Random().Next(0, 201);
    }
}

void PrintArray (int[] arr)
{
    int length = arr.Length;
    Console.Write("Your array: { ");
    for (int index = 0; index < length; index++)
    {
        if (index < length -1) Console.Write(arr[index] + ", ");
        else Console.Write(arr[index] + " ");
    }
    Console.Write("}");
    Console.WriteLine();
}