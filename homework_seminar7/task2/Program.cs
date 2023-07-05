/* Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента
или же указание, что такого элемента нет.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
17 -> такого числа в массиве нет */

System.Console.Write("Введи строку ");
int num_row = Convert.ToInt32(Console.ReadLine());

System.Console.Write("Введи столбец ");
int num_column = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("");
int m = 3;
int n = 4;


void PrintArray(int [,] matr)
{
for (int i = 0; i < m; i++)
{
    for (int j = 0; j < n; j++)
    {
        Console.Write($"{matr[i,j]} ");
    }
    Console.WriteLine();
}
}

void FillArray(int [,] matr)
{
for (int i = 0; i < m; i++)
{
    for (int j = 0; j < n; j++)
    {
        matr[i,j] = new Random().Next(1, 10);
    }
}
}

int[,] matrix = new int[m, n];

FillArray(matrix);
Console.WriteLine("Исходный массив: ");
PrintArray(matrix);
Console.WriteLine("");


if (num_row < 0 || num_column < 0 || num_column > n || num_row > m)
{
    Console.WriteLine("Такого элемента не существует");
}
 else
{
Console.WriteLine($"данный элемент {matrix[num_row - 1, num_column - 1]}"); 
}

 
Console.WriteLine("");


