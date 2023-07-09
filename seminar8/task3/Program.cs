/* Задайте двумерный массив из целых чисел. Напишите программу, которая удалит строку и столбец, на пересечении которых расположен 
наименьший элемент массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Наименьший элемент - 1, на выходе получим 
следующий массив:
9 4 2
2 2 6
3 4 7 */
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

int min = matrix[0,0];
int indexRow = 0;
int indexColumn = 0;
for (int i = 0; i < m; i++)
{
    for (int j = 0; j < n; j++)
    {
        
        if (matrix[i,j] < min)
        {
            min = matrix[i,j];
            indexRow = i;
            indexColumn = j;
            
        }
    }
}
    Console.WriteLine($"Минимальное значение = {min} , индекс строки = {indexRow}, индекс столбца = {indexColumn}");
for (int i = 0; i < m; i++)
{
    int temp = 0;
    matrix[i, indexColumn] = temp;
}
Console.WriteLine();
for (int j = 0; j < n; j++)
{
    int temp = 0;
    matrix[indexRow,j] = temp;
}
Console.WriteLine();

for (int i = 0; i < m; i++)
{
    for (int j = 0; j < n; j++)
    {
        Console.Write($"{matrix[i,j]} ");
    }
    Console.WriteLine();
}