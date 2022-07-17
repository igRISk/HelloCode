// Напишите программу для вычисления площади круга, прямоугольника и треугольника. 
// Ввод данных осуществляется в диалоговом режиме. 
// На первом шаге у пользователя запрашивается фигура, площадь которой нужно вычислить. 
// На втором шаге пользователь вводит параметры, необходимые для рассчета. Затем, выводится результат.

Console.Write("Which shape will we calculate the area of: 1 - circle, 2 - rectangle, 3 - triangle = ");
int num = int.Parse(Console.ReadLine());

while (num < 1 || num > 3)
    {
        Console.Write("Let's try again: 1 - circle, 2 - rectangle, 3 - triangle = ");
        num = int.Parse(Console.ReadLine());
    }

switch (num)
{
    case 1:
    {
        Console.Write("Specify the radius of the circle: ");
        int rad = int.Parse(Console.ReadLine());
        double circleSquare = Math.PI * rad * rad;
        Console.WriteLine("Area of circle is ~ " + Math.Round(circleSquare, 2));
        break;
    }
    case 2:
    {
        Console.Write("Specify the length of side 1 of rectangle: ");
        int recL1 = int.Parse(Console.ReadLine());
        Console.Write("Specify the length of side 2 of rectangle: ");
        int recL2 = int.Parse(Console.ReadLine());
        int recSquare =  recL1 * recL2;
        Console.WriteLine("Area of rectangle is ~ " + recSquare);
        break;
    }
    case 3:
    {
        Console.Write("Specify the length of side 1 of triangle: ");
        double a = double.Parse(Console.ReadLine());
        Console.Write("Specify the length of side 2 of triangle: ");
        double b = double.Parse(Console.ReadLine());
        Console.Write("Specify the length of side 3 of triangle: ");
        double c = double.Parse(Console.ReadLine());
        double p = (a + b + c) / 2;
        double triSquare =  Math.Sqrt(p*(p-a)*(p-b)*(p-c));
        Console.WriteLine("Area of triangle is ~ " + Math.Round(triSquare, 2));
        break;
    }
}