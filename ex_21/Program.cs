using System;

// Задача 21: Напишите программу, которая принимает на вход 
// координаты двух точек и находит расстояние между ними в 3D 
// пространстве.

Console.Write("Input first point coordinates: X1 Y1 Z1: ");
string point1 = Console.ReadLine()!;
string[] parts1 = point1.Split(' ');
int X1 = int.Parse(parts1[0]);
int Y1 = int.Parse(parts1[1]);
int Z1 = int.Parse(parts1[2]);

Console.Write("Input second point coordinates: X2 Y2 Z2: ");
string point2 = Console.ReadLine()!;
string[] parts2 = point2.Split(' ');
int X2 = int.Parse(parts2[0]);
int Y2 = int.Parse(parts2[1]);
int Z2 = int.Parse(parts2[2]);

double distance = Math.Sqrt(Math.Pow(X2 - X1, 2) + Math.Pow(Y2 - Y1, 2) + Math.Pow(Z2 - Z1, 2));
Console.WriteLine($"Расстояние между двумя точками равно {distance:F2} единиц.");

// void XYZ(int i) // ввод данных через метод
// {
//     Console.Write($"Input coordinates X Y Z of point {i}: ");
//     string point = Console.ReadLine()!;
//     string[] parts = point.Split(' ');
//     int X = int.Parse(parts[0]);
//     int Y = int.Parse(parts[1]);
//     int Z = int.Parse(parts[2]);
// }
// XYZ(1);
// XYZ(2);

// ВОПРОС: можно ли как-то дальше реализовать формулу расстояния,
// используя эти данные? результатом использования этого метода
// в обоих случаях получаются одинаковые переменные X Y Z, но для
// вычисления дальше нужны X1 Y1 Z1 и X2 Y2 Z2, можно ли их как-то
// внутри этого метода завязать на i: Xi Yi Zi?

// Отвечаю на Ваш вопрос. Конечно, можно. Но всё зависит от того, как именно Вы хотите это реализовать. Вот такой вариант, например:

// / double[,] FillCoordinates(int numberCoor)
// {
// int point = 2;
// double[,] coordinates = new double[numberCoor, point];
// for (int k = 0; k < numberCoor; k++)
// {
//     for (int m = 0; m < point; m++)
//     {
//         Console.Write($"Input coordinate {k + 1} of point {m + 1}: ");
//         coordinates[k, m] = double.Parse(Console.ReadLine());
//     }
// }
// return coordinates;
// }
// И вот у Вас массив, в котором столбцы соответствуют точкам, а строки координатам.