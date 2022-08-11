/* Напишите программу, которая последовательно выводит числа от 1 до 100,
но если число делится на 3, заменяет его на Fizz, если делится на 5 то на Buzz,
а если и на 3 и на 5, то на FizzBuzz */

for (int i = 1; i <= 100; i++)
{
    if (i % 3 == 0 && i % 5 == 0)
        Console.Write(" FizzBuzz");
    else if (i % 3 == 0)
        Console.Write(" Fizz");
    else if (i % 5 == 0)
        Console.Write(" Buzz");
    else
        Console.Write(" " + i);
}