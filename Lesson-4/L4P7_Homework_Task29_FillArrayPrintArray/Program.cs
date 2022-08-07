

void FillArray(int[] collection)
{
    int length = collection.Length;
    int index = 0;
    while (index < length)
    {
        collection[index] = new Random().Next(1, 10);
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
        Console.Write(col[position] + " ");
        position++;
    }
    Console.Write("}");
}

int size = 8;
int[] array = new int[size];

FillArray(array);
PrintArray(array);
Console.WriteLine();