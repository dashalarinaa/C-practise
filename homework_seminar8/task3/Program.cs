// Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

// Чтобы можно было умножить две матрицы, количество столбцов первой матрицы должно быть равно количеству строк второй матрицы.

System.Console.Write("Enter num rows1: ");
int m = Convert.ToInt32(Console.ReadLine());

System.Console.Write("Enter num columns1: ");
int n = Convert.ToInt32(Console.ReadLine());

System.Console.Write("Enter num rows2: ");
int m2 = Convert.ToInt32(Console.ReadLine());

System.Console.Write("Enter num columns2: ");
int n2 = Convert.ToInt32(Console.ReadLine());
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
void PrintArray2(int [,] matr)
{
for (int i = 0; i < m2; i++)
{
    for (int j = 0; j < n2; j++)
    {
        Console.Write($"{matr[i,j]} ");
    }
    Console.WriteLine();
}
}

void FillArray2(int [,] matr)
{
for (int i = 0; i < m2; i++)
{
    for (int j = 0; j < n2; j++)
    {
        matr[i,j] = new Random().Next(1, 10);
    }
}
}

int[,] matrix1 = new int[m, n];
int[,] matrix2 = new int[m2, n2];
FillArray(matrix1);
PrintArray(matrix1);
Console.WriteLine("");
FillArray2(matrix2);
PrintArray2(matrix2);
Console.WriteLine("");