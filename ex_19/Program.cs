using System;

// Задача 19: Напишите программу, которая принимает на вход 
// пятизначное число и проверяет, является ли оно палиндромом.

Console.Write("Input five-digit number: ");
string number = Console.ReadLine()!;
char[] array = number.ToCharArray(0, number.Length);
Console.Write(array);

// Цикл работает с числом из любого кол-ва цифр и любой строкой!
for (int i = 0; i < number.Length / 2; i++)
{
    if (array[i] != array[number.Length - 1 - i])
    {
        Console.Write(" -> NO");
        break;
    }
    else if (number.Length - 1 - i - i <= 2)
        Console.Write(" -> YES");
    else continue;
}