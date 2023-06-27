﻿// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

int[] array = new int [5];
for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next (1, 100);
    Console.WriteLine (array[i]);
}

int max = array[1];
int min = array[1];

for (int i = 0; i < array.Length; i++)
{
    if (array[i] > max)
    {
        max = array[i]; 
    }

     if (array[i] < min)
    {
        min = array[i];
    }
}
Console.WriteLine($" Максимальное значение = {max}, минимальное значение = {min}");
Console.WriteLine($"Разница между максимальным и минимальным значением = {max - min}");
