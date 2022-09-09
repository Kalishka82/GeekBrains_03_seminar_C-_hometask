using System;

// Задача 19: Напишите программу, которая принимает на вход 
// пятизначное число и проверяет, является ли оно палиндромом.

Console.Write("Input five-digit number: ");
string number = Console.ReadLine()!;
Console.Write(number);

void Polindrom(string number)
{
// === Цикл работает с числом из любого кол-ва цифр и любой строкой ===
    bool check = true;
    for (int i = 0; i < number.Length / 2; i++)
    {
        check = check & number[i] == number[number.Length - i - 1];
        // if (number[i] != number[number.Length - 1 - i])
        // {
        //     Console.Write(" -> NO");
        //     break;
        // }
        // else if (number.Length - 1 - i - i <= 2)
        //     Console.Write(" -> YES");
    }
    string txt = check == true? " -> YES" : " -> NO"; 
    Console.WriteLine(txt);
}

Polindrom(number);