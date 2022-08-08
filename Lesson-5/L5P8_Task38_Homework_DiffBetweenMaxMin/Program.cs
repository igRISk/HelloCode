/* Задача 38: Задайте массив вещественных чисел. 
Найдите разницу между максимальным и минимальным элементов массива. 
[3 7 22 2 78] -> 76 */

Console.Write("Enter size of array: ");
int size = int.Parse(Console.ReadLine());
float[] array = new float[size];

array = FillArray(size);
PrintArray(array);

float difmm = DifMaxMin(array);
Console.Write("Difference between max and min = " + difmm);



float DifMaxMin (float[] arr)
{
    float min = arr[0];
    float max = arr[0];
    for (int i = 1; i < arr.Length; i++)
    {
        if (min > arr[i])
            min = arr[i];
        if (max < arr[i])
            max = arr[i];
    }   
    float dmm = max - min;
    return dmm;
}

float[] FillArray(int n)
{
    float[] array = new float[n];
    Random rnd = new Random();
    double rmin = 1;
    double rmax = 100;
    double rrange = rmax - rmin;
    for (int i = 0; i < n; i++)
    {
        double sample = rnd.NextDouble();
        double scaled = (sample * rrange) + rmin;
        array[i] = (float)scaled;
    }
    return array;
}

void PrintArray(float[] arr)
{
    int length = arr.Length;
    Console.Write("Your array: { ");
    for (int index = 0; index < length; index++)
    {
        if (index < length - 1) Console.Write(arr[index] + "; ");
        else Console.Write(arr[index] + " ");
    }
    Console.Write("}");
    Console.WriteLine();
}