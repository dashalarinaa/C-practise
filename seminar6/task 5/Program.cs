﻿// Напишите программу, которая будет создавать копию заданного массива с помощью поэлементного копирования.
// Создаем массив на 8-16 чисел и случайными значениями внутри от 0 до 999
double[] array = new double[new Random().Next(8,17)];
Console.Write("Получен массив содержащий следующие элементы ");
for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(0, 1000);
    Console.Write(array[i] + " ");
}
Console.WriteLine(" ");

double[] copy = new double[new Random().Next(8,17)];
Console.Write("Копия массива содержит следующие значения: ");
for (int j = 0; j < array.Length; j++)
{
    copy[j] = array[j];
    Console.Write(array[j]+ " ");
}