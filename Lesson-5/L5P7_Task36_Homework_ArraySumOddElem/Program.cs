/* Задача 36: Задайте одномерный массив, заполненный случайными числами. 
Найдите сумму элементов, стоящих на нечётных позициях. 
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0 */

Console.Write("Enter size of array: ");
int size = int.Parse(Console.ReadLine());
int[] array = new int[size];

FillArray(array);
PrintArray(array);

int sumodd =SumOddElem(array);
Console.Write("Sum of odd elements = " + sumodd);

int SumOddElem(int[] arr)
{
    int l = arr.Length;
    int sum = 0;
    for (int i = 1; i < l; i+=2)
        sum = sum + arr[i];
    return sum;
}

void FillArray(int[] arr)
{
    int length = arr.Length;
    for (int index = 0; index < length; index++)
    {
        arr[index] = new Random().Next(-10, 11);
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