// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// -1, -7, 567, 89, 223-> 3

Console.WriteLine();
Console.Write("Enter numbers separated by spaces (array): ");
int[] array = Console.ReadLine().Split().Select(int.Parse).ToArray();
int num = 0;

for (int i = 0; i < array.Length; i++)
{
    if (array[i] > 0)
        num++;
}

System.Console.Write("\n {0}", String.Join(", ", array));
Console.WriteLine(" -> " + num + "\n");