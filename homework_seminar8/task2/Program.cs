// Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
System.Console.Write("Enter num rows: ");
int m = Convert.ToInt32(Console.ReadLine());

System.Console.Write("Enter num columns: ");
int n = Convert.ToInt32(Console.ReadLine());


Console.WriteLine();

if (m != n)
{
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

int GetSumRow(int [,] matr)
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
Console.WriteLine("");
int minSum = sum[0];
int minRow = 1;
for (int i = 0; i < m; i++)
{
    if (sum[i] < minSum)
    {
        minSum = sum[i];
        minRow = i + 1;
    }
}
return minRow;
}

int row = GetSumRow(matrix);
Console.WriteLine($"Наименьшая сумма чисел находится в строке {row}");
}
else
{
    Console.WriteLine("Числа не должны быть равными");
}
