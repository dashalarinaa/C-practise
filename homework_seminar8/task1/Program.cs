// Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
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


for (int i = 0; i < m; i++)
{
    for (int j = 0; j < n; j++)
    {
        for (int k = 0; k < m-1; k++)
        {
            if (matrix [i, k] < matrix [i, k+1])
            {
                int temp = matrix [i, k+1];
                matrix [i, k+1] = matrix [i, k];
                matrix [i, k] = temp;
            }
        }
    }
}    

for (int i = 0; i < m; i++)
{
    for (int j = 0; j < n; j++)
    {
        Console.Write($"{matrix[i,j]} ");
    }
    Console.WriteLine();
}