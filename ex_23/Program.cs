using System;

// Задача 23: Напишите программу, которая принимает на вход число 
// (N) и выдаёт таблицу кубов чисел от 1 до N.

Console.Write("Input number: ");
int N = int.Parse(Console.ReadLine()!);

    for (int i = 1; i <= N; i++)
    {
        Console.Write(Math.Pow(i, 3));
        if (i < N)
        Console.Write(", ");
    }
