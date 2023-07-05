﻿/* Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
m = 3, n = 4.
0,5 7 -2 -0,2
1 -3,3 8 -9,9
8 7,8 -7,1 9 */

System.Console.Write("Enter num rows: ");
int m = Convert.ToInt32(Console.ReadLine());

System.Console.Write("Enter num columns: ");
int n = Convert.ToInt32(Console.ReadLine());


void PrintArray(double [,] matr)
{
for (int  i = 0; i < m; i++)
{
    for (int  j = 0; j < n; j++)
    {
        Console.Write($"{matr[i,j]} ");
    }
    Console.WriteLine();
}
}

void FillArray(double [,] matr)
{
for (int  i = 0; i < m; i++)
{
    for (int j = 0; j < n; j++)
    {
        matr[i,j] = Math.Round((new Random().NextDouble() * 10), 2);
    }
}
}


double [,] matrix = new double [m, n];

FillArray(matrix);
PrintArray(matrix);

