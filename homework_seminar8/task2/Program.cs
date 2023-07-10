// Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
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

void GetSumRow(int [,] matr)
{
    int[] sum = new int [m];
for (int i = 0; i < m; i++)
{
    for (int j = 0; j < n; j++)
    {
        sum[i] = sum[i] + matr[i,j];
        
    }
     Console.Write(sum[i] + " ");
} 
}
GetSumRow(matrix);



