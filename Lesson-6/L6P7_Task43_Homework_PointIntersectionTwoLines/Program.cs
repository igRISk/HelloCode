// Задача 43. Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями 
// y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; 5,5)

Console.Write("Enter b1 please: ");
float b1 = int.Parse(Console.ReadLine());
Console.Write("Enter k1 please: ");
float k1 = int.Parse(Console.ReadLine());
Console.Write("Enter b2 please: ");
float b2 = int.Parse(Console.ReadLine());
Console.Write("Enter k2 please: ");
float k2 = int.Parse(Console.ReadLine());

float x = (b2 - b1) / (k1 - k2); // x = (4 - 2) / (5 - 9) = 2 / -4 = -0.5 
float y = k1 * x + b1; // y = 5 * -0.5 + 2 = -2.5 + 2 = - 0.5; y = 9 * -0.5 + 4 = - 4.5 + 4 = - 0.5

Console.WriteLine($"b1 = {b1}, k1 = {k1}, b2 = {b2}, k2 = {k2} -> ({x,0:f1}; {y,0:f1})");



// k1 * x + b1 = k2 * x + b2
// k1 * x - k2 * x = b2 - b1
// (k1 - k2) * x = b2 - b1