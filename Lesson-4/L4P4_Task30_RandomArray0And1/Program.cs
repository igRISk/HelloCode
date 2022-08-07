/* Задача 30: Напишите программу, которая выводит массив из 8 элементов, заполненный
нулями и единицами в случайном порядке.
[1,0,1,1,0,1,0,0] */

Console.Write("Enter size of array: ");
int size = int.Parse(Console.ReadLine());

int[] array = FillArray(size);
PrintArray(array);



int[] FillArray(int n)
{
   int[] array = new int[n];
   Random rnd = new Random();
   for (int i = 0; i < n; i++)
   {
    array[i] = rnd.Next(0, 2);
   }
   return array;
}

void PrintArray(int[] arr)
{
    int count = array.Length;
    for (int i = 0; i < count; i++)
        Console.Write($"{array[i]} ");
    Console.WriteLine();
}