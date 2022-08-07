//Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

Console.Write("Enter numbers separated by spaces: ");
int[] array = Console.ReadLine().Split().Select(int.Parse).ToArray();

PrintArray(array);
Console.WriteLine();



void PrintArray (int[] col)
{
    int count = col.Length;
    int position = 0;
    Console.Write("Your array: { ");
    while (position < count)
    {
        Console.Write(col[position] + " ");
        position++;
    }
    Console.Write("}");
}