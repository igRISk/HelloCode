using System.Linq;

int a = 1;
Console.WriteLine(a.GetType());
Console.WriteLine(a.GetType().Name);

var b = 1; // var - неявная типизация var нельзя использовать без присвоения
Console.WriteLine(b.GetType());
Console.WriteLine(b.GetType().Name);

var data = new int[]{1,2,3,4}
        .Where (e => e > 0)
        .Select(e => new {q = e, w = e + 1});

Console.WriteLine(data.GetType());
Console.WriteLine(data.GetType().Name);