using System;

// 1. Пользователь вводит x и y. Программа печатает, чему равно 
// x² + y².
Console.Write("Input x = ");
int x = int.Parse(Console.ReadLine()!);
Console.Write("Input y = ");
int y = int.Parse(Console.ReadLine()!);

double Result(int x, int y)
{
    double result = Math.Pow(x, 2) + Math.Pow(y, 2);
    return result;
}
Console.WriteLine(Result(x, y));
Console.WriteLine();

// 2. Программа печатает, какое отношение верно: x < y, x = y, x > y
void inequation(int x, int y)
{
    if (x < y) 
        Console.WriteLine($"{x} <  {y}");
    else if (x == y) 
        Console.WriteLine($"{x} = {y}");
    else
        Console.WriteLine($"{x} > {y}");
}
inequation(x, y);
Console.WriteLine();

// 3. Пользователь вводит a и b. Программа печатает все числа 
// от a до b.
Console.Write("Input a = ");
int a = int.Parse(Console.ReadLine()!);
Console.Write("Input b = ");
int b = int.Parse(Console.ReadLine()!);

void stringAB(int a, int b)
{
    int i = a;
    int count = b;
    while (i <= count)
    {
        Console.Write(i);
        if (i < count)
            Console.Write(" ");
        i += 1;
    }
    Console.WriteLine();
}

stringAB(a, b);
Console.WriteLine();

// 4. Пользователь вводит возраст. Если ему меньшу 18 лет или 
// больше 65 лет, программа говорит, что для него есть скидка.
Console.Write("Input your age: ");
int age = int.Parse(Console.ReadLine()!);
if (age < 18 || age > 65)
    Console.WriteLine("You have a discount");
Console.WriteLine();

// 5. Пользователь вводит координаты x, y точки на плоскости. 
// Программа печатает расстояние от начала координат (0, 0) 
// до точки (x, y). (Используйте теорему Пифагора).
Console.Write("Input point coordinates X Y ");
string point = Console.ReadLine()!;
string[] parts = point.Split(' ');
int X = int.Parse(parts[0]);
int Y = int.Parse(parts[1]);
double distance = Math.Sqrt(Math.Pow(X, 2) + Math.Pow(Y, 2));
Console.WriteLine($"{distance:F2}");
Console.WriteLine();

// 6. Пользователь вводит координаты двух точек A и B на плоскости. 
// Программа определяет, какая из них дальше от начала координат.
Console.Write("Input point A coordinates xA yA ");
string pointA = Console.ReadLine()!;
string[] partsA = pointA.Split(' ');
int xA = int.Parse(partsA[0]);
int yA = int.Parse(partsA[1]);
double distanceA = Math.Sqrt(Math.Pow(xA, 2) + Math.Pow(yA, 2));

Console.Write("Input point B coordinates xB yB ");
string pointB = Console.ReadLine()!;
string[] partsB = pointB.Split(' ');
int xB = int.Parse(partsB[0]);
int yB = int.Parse(partsB[1]);
double distanceB = Math.Sqrt(Math.Pow(xB, 2) + Math.Pow(yB, 2));

if (distanceA > distanceB)
    Console.WriteLine("Point A is farther on B");
else if (distanceB > distanceA)
    Console.WriteLine("Point B is farther on A");