// В случайных точках консоли вывести случайные числа

Random rnd = new Random();
Console.CursorVisible = false;

while (true)
{
    Console.SetCursorPosition(
        left: rnd.Next(Console.WindowWidth), 
        top: rnd.Next(Console.WindowHeight)
        );
    Console.Write(rnd.Next(10));
    Thread.Sleep(10);
}