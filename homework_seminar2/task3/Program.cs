﻿// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.Write("Введи число");
int number = int.Parse(Console.ReadLine());

if (number > 100 && number < 999)
{
    int result = number % 10;
    Console.Write($"Третье число {result}");
}
else
{
    Console.Write("Третьего числа нет");
}


