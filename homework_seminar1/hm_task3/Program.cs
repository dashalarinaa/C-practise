﻿// Напишите программу, которая на вход принимает 
// число и выдает, является ли число четным (делится ли оно на 
// два без остатка).
// 4 -> да
// -3 -> нет
// 7 -> нет

Console.Write("Введи число");
int number = int.Parse(Console.ReadLine());

if (number % 2 == 0)
{
    Console.WriteLine($"Число {number} Четное");
}
else
{
    Console.WriteLine($"Число {number} Нечетное");
}