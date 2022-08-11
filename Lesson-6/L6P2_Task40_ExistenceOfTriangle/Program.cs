/* Задача 40: Напишите программу, которая принимает на вход три числа и проверяет, 
может ли существовать треугольник с сторонами такой длины. */

int n = 3;
int[] array = new int[n];

for (int i = 0; i < n; i++)
{
    Console.Write("Enter number " + (i+1) +": " );
    array[i] = int.Parse(Console.ReadLine());
}

if (isTriangle(array))
    Console.WriteLine("Such triangle exists");
else
    Console.WriteLine("Such triangle does not exist");



bool isTriangle (int[] arr)
{
    if (array[0] < array[1] + array[2] && array[1] < array[0] + array[2] && array[2] < array[0] + array[1])
        return true;
    else
        return false;
}