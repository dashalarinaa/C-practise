﻿// Напишите программу, которая выводит массив из 8 элементов, заполненный нулями и единицами в случайном порядке.
// [1,0,1,1,0,1,0,0]
//int size = 10;
//int[] array = new int[size]
//Console.WriteLine(array[1]);
//Console.ReadKey();


int[] array = new int [8];

for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next (0, 2);
    Console.WriteLine (array[i]);
}