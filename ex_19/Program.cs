using System;

// Задача 19: Напишите программу, которая принимает на вход 
// пятизначное число и проверяет, является ли оно палиндромом.

Console.Write("Input five-digit number: ");
string number = Console.ReadLine()!;
Console.Write(number);

void Polindrom(string number)
{
// === Цикл работает с числом из любого кол-ва цифр и любой строкой ===
    for (int i = 0; i < number.Length / 2; i++)
    {
        if (number[i] != number[number.Length - 1 - i])
        {
            Console.Write(" -> NO");
            break;
        }
        else if (number.Length - 1 - i - i <= 2)
            Console.Write(" -> YES");
        else continue;
    }
}

Polindrom(number);