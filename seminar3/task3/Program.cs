﻿// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу квадратов чисел 
// от 1 до N.
// 5 -> 1, 4, 9, 16, 25.
// 2 -> 1,4

Console.Write("Введи число");
int N = int.Parse(Console.ReadLine());

int count = 1;

while ( count < N)
{
    count++;
    Console.WriteLine(count * count);
}