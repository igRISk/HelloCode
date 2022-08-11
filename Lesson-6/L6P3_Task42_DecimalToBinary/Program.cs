// Задача 42: Напишите программу, которая будет преобразовывать десятичное число в двоичное.
// 45 -> 101101
// 3 -> 11
// 2 -> 10

Console.Write("Enter decimal number please: ");
int decnum = int.Parse(Console.ReadLine());

Console.Write(decnum + " -> ");
int[] binarray = DecToBin(decnum);
PrintArray(binarray);



int[] DecToBin(int num)
{
    int l = 0;
    int tmp = num;
    while (tmp !=0)
    {
        tmp = tmp / 2;
        l++;
    }
    int[] arr = new int[l];
    for (int i = l - 1; i >= 0; i--)
    { 
        arr[i] = num % 2;
        num = num / 2;
    }
    return arr;
}

void PrintArray(int[] arr)
{
    int length = arr.Length;
    for (int index = 0; index < length; index++)
    {
       Console.Write(arr[index]);
    }
}