// [1, 3, 5, 7]
// [2, 4, 6, 8]
// -> [1, 2, 3, 4, 5, 6, 7, 8]

Console.Write("Enter numbers separated by spaces (array 1): ");
int[] array1 = Console.ReadLine().Split().Select(int.Parse).ToArray();
Console.Write("Enter numbers separated by spaces (array 2): ");
int[] array2 = Console.ReadLine().Split().Select(int.Parse).ToArray();

int size1 = array1.Length;
int size2 = array2.Length;
int sizes = size1 + size2;
int[] array = new int[sizes];
 
PrintArray(array1);
PrintArray(array2);

array = JoinArrays(array1, array2);
SelectionSort(array);
PrintArray(array);

int[] JoinArrays(int[] arr1, int[] arr2)
{
    int l1 = arr1.Length;
    int l2 = arr2.Length;
    int sl = l1 + l2;
    int[] arr = new int[sl];
    for (int i = 0; i < sl; i++)
    if (i < l1) 
        arr[i] = arr1[i];
    else 
        arr[i] = arr2[i - l1];
    return arr;
}

void SelectionSort(int[] arr)
{
    for (int i = 0; i < arr.Length - 1; i++)
    {
        int minPosition = i;
        for (int j = i + 1; j < arr.Length; j++)
            if (arr[j] < arr[minPosition])
                minPosition = j;
        int temporary = arr[i];
        arr[i]= arr[minPosition];
        arr[minPosition] = temporary;
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