/* Задача 34: Задайте массив заполненный случайнымиположительными трёхзначными числами. 
Напишите программу, которая покажет количество чётных чисел в массиве.
[345, 897, 568, 234] -> 2 */

Console.Write("Enter size of array: ");
int size = int.Parse(Console.ReadLine());
int[] array = new int[size];

FillArray(array);
PrintArray(array);

int evenqty = NumberEven(array);
Console.Write("Amount of even numbers = " + evenqty);

int NumberEven(int[] arr)
{
    int l = arr.Length;
    int qty = 0;
    for (int i = 0; i < l; i++)
        if (arr[i] % 2 == 0)
            qty++;
    return qty;
}

void FillArray(int[] arr)
{
    int length = arr.Length;
    for (int index = 0; index < length; index++)
    {
        arr[index] = new Random().Next(100, 1000);
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
    Console.WriteLine();
}