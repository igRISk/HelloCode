// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.Write("Enter a number: ");
int num = int.Parse(Console.ReadLine());

int i = 0;
int numA = num;

while (num > 0)
{
    num = num / 10;
    i++;
}

int[] numArray = new int[i];
int a = 0;
int rank = Convert.ToInt32(Math.Pow(10, i-1));

while (a < i)
{
    numArray[a] = numA / rank % 10;
    rank = rank / 10;
    a++;
}
    
if (numA > 99)
    Console.WriteLine(numA + " -> " + numArray[2]);
else
    Console.WriteLine(numA + " -> no third digit");