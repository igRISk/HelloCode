/* Задача 33: Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.
4; массив [6, 7, 19, 345, 3] -> нет
-3; массив [6, 7, 19, 345, 3] -> да */

Console.Write("Enter size of array: ");
int size = int.Parse(Console.ReadLine());
int[] array = new int[size];

FillArray(array);
PrintArray(array);
Console.WriteLine();

Console.Write("Enter a number: ");
int num = int.Parse(Console.ReadLine());

bool answer = Contains(array, num);

if (answer) Console.Write(" -> yes");
else Console.Write(" -> no");



bool Contains(int[] arr, int n)
{
    int length = arr.Length;
    for (int i = 0; i < length; i++)
        if (arr[i] == n)
            return true;
    return false;
}

void FillArray(int[] arr)
{
    int length = arr.Length;
    for (int index = 0; index < length; index++)
    {
        arr[index] = new Random().Next(0, 10);
    }
}

void PrintArray(int[] arr)
{
    int length = arr.Length;
    Console.Write("Your array: { ");
    for (int index = 0; index < length; index++)
    {
        if (index < length - 1) Console.Write(arr[index] + ", ");
        else Console.Write(arr[index] + " ");
    }
    Console.Write("}");
}