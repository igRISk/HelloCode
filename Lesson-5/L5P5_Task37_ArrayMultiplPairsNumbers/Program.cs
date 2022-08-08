/* Задача 37: Найдите произведение пар чисел в одномерном массиве.
Парой считаем первый и последний элемент, второй и предпоследнийи т.д. Результат запишите в новом массиве.
[1 2 3 4 5] -> 5 8 3
[6 7 3 6] -> 36 21 */

Console.Write("Enter size of array: ");
int size = int.Parse(Console.ReadLine());
int[] array = new int[size];

FillArray(array);
PrintArray(array);

int sizear = 0;
if (size % 2 == 0)
    sizear = size / 2;
else
    sizear = size / 2 + 1;

int[] arrres = new int[sizear];

for (int i = 0; i < sizear; i++)
    if (i != size - 1 - i)
        arrres[i] = array[i] * array[size - 1 - i];
    else
        arrres[i] = array[i];

PrintArray(arrres);


void FillArray(int[] arr)
{
    int length = arr.Length;
    for (int index = 0; index < length; index++)
    {
        arr[index] = new Random().Next(0, 10);
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