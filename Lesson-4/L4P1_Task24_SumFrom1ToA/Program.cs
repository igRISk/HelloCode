// Задача 24: Напишите программу, которая // принимает на вход число (А) и выдаёт сумму чисел от 1 до А.
// 7 -> 28
// 4 -> 10
// 8 -> 36

Console.Write("Enter a number: ");
int num = int.Parse(Console.ReadLine());
int sum = 0;

for (int i = 1; i <= num; i++)
{
    sum = sum + i;
}

Console.Write(num + " -> " + sum);

//while (i <= num)
//{
//    sum = sum + i;
//    i++;
//}
