// Вид (группа) 2 - что-то принимают, ничего не возвращают

void Method2(string msg)
{
    Console.WriteLine(msg);
}

void Method21(string msg, int count)
{
    int i = 0;
    while (i < count)
    {
        Console.WriteLine(msg);
        i++;
    }
}

Method2(msg: "Text"); // Method2("Text");
Method21(count: 4, msg:"Text"); // Method21("Text", 4);