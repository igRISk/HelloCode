// Задача 44: Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: 0 и 1.

// Если N = 5 -> 0 1 1 2 3
// Если N = 3 -> 0 1 1
// Если N = 7 -> 0 1 1 2 3 5 8

Console.Write("Enter a number please: ");
int num = int.Parse(Console.ReadLine());
float[] array = new float[num];
array[0] = 0;
array[1] = 1;

for (int i = 2; i < num; i++)
    array[i] = array [i-1] + array [i-2];

System.Console.WriteLine("\n Fibonacci sequence: {0}", String.Join(" ", array));
Console.WriteLine();