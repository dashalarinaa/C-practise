// Задайте двумерный массив. Напишите программу, которая заменяет строки на столбцы.
// В случае, если это невозможно, программа должна вывести сообщение для пользователя.

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

int[,] matrixNew = new int[n, m];
for (int j = 0; j < n; j++)
{
    for (int i = 0; i < m; i++)
    {
        matrixNew[j,i] = matrix [i,j];
    }    
}

for (int j = 0; j < n; j++)
{
    for (int i = 0; i < m; i++)
    {
        Console.Write($"{matrixNew[j,i]} ");
    }
    Console.WriteLine();
}    