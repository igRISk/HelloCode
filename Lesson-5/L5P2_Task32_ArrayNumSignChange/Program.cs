/* Задача 32: Напишите программу замена элементов массива: положительные элементы замените на
соответствующие отрицательные, и наоборот.
[-4, -8, 8, 2] -> [4, 8, -8, -2] */

Console.Write("Enter size of array: ");
int size = int.Parse(Console.ReadLine());
int[] array = new int[size];

FillArray(array);
PrintArray(array);
ArraySignReverse(array);
PrintArray(array);



void ArraySignReverse(int[] arr)
{
    int length = arr.Length;
    for (int index = 0; index < length; index++)
        arr[index] = -arr[index];
}

void FillArray(int[] arr)
{
    int length = arr.Length;
    for (int index = 0; index < length; index++)
    {
        arr[index] = new Random().Next(-9, 10);
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