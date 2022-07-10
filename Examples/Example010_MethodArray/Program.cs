int[] array= { 1, 12, 31, 4, 18, 15, 4, 43, 55 };

int n = array.Length;
Console.Write("Please enter a number: ");
int find = int.Parse(Console.ReadLine());

int index = 0;

while (index < n)
{
    if (array[index] == find)
    {
        Console.WriteLine("Element index in array = " + index);
        break;
    }
    index++;
}
