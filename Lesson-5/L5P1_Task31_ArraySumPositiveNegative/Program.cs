/* Задача 31: Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9]. 
Найдите сумму отрицательных и положительных элементов массива.
Например, в [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма положительных чисел равна 29, сумма отрицательных равна -20. */

int size = 12;
int[] array = new int[size];

FillArray(array);
PrintArray(array);

int []sumpn = SumPosNeg(array);
Console.WriteLine("Sum of positive = " + sumpn[0] + "; sum of negative = "+ sumpn[1]);



int[] SumPosNeg (int[] arr)
{
    int i = 0;
    int l = arr.Length;
    int[] sum = new int[2];
    while (i < l)
    {
        if (arr[i] > 0) sum[0] = sum[0] + arr[i];
        else sum[1] = sum[1] + arr[i];
        i++;
    }
    return sum;
}

void FillArray(int[] collection)
{
    int length = collection.Length;
    int index = 0;
    while (index < length)
    {
        collection[index] = new Random().Next(-9, 10);
        index++;
    }
}

void PrintArray (int[] col)
{
    int count = col.Length;
    int position = 0;
    Console.Write("Your array: { ");
    while (position < count)
    {
        if (position < count -1) Console.Write(col[position] + ", ");
        else Console.Write(col[position] + " ");
        position++;
    }
    Console.Write("}");
    Console.WriteLine();
}