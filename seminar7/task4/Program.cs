// Задайте двумерный массив. Найдите сумму элементов, находящихся на главной диагонали (с индексами (0;0); (1;1) и т.д.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Сумма элементов главной диагонали: 1+9+2 = 12

System.Console.Write("Enter num rows: ");
int m = Convert.ToInt32(Console.ReadLine());

System.Console.Write("Enter num columns: ");
int n = Convert.ToInt32(Console.ReadLine());


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
PrintArray(matrix);
Console.WriteLine("");

int result = 0; 

for (int i = 0; i < m; i++)
{
    for (int j = 0; j < n; j++)
    {
        if (i == j) 
        result = result + matrix[i,j];
    }
}
Console.WriteLine($"Сумма элементов, находящихся на главной диагонали равна {result}");    