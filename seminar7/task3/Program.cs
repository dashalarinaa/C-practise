/* Задайте двумерный массив. Найдите элементы, у которых оба индекса чётные, и замените эти элементы на их квадраты.
Например, изначально массив
выглядел вот так:
1 4 7 2
5 9 2 3
8 4 2 4
Новый массив будет выглядеть 
вот так:
1 4 7 2
5 81 2 9
8 4 2 4 */

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

void FillArray2 (int [,] matr)
{
for (int i = 0; i < m; i++)
{
    for (int j = 0; j < n; j++)
    {
        if (i % 2 != 0 && j % 2 != 0 && i > 0 && j > 0) 
        {
            matr[i,j]  = matr[i,j] * matr[i,j]; 
        }
    }
}
}
int[,] matrix = new int[m, n];
PrintArray(matrix);
Console.WriteLine("");
FillArray(matrix);
PrintArray(matrix);
Console.WriteLine("");
FillArray2 (matrix);
PrintArray(matrix);



