﻿// Напишите программу, которая по заданному номеру четверти, показывает диапазон возможных координат точек в этой четверти (x и y).
Console.Write("Введи номер четверти от 1 до 4");
int number = int.Parse(Console.ReadLine());


switch (number)
{
    case (1):
        Console.WriteLine("x > 0, y > 0");
        break;
    case (2):
        Console.WriteLine("x > 0, y < 0");
        break;
    case (3):
        Console.WriteLine("x < 0, y < 0");
        break;
    case (4):
        Console.WriteLine("x < 0, y > 0");
        break;
    
    default:
        Console.WriteLine("Такой четверти не существует");
        break;
}