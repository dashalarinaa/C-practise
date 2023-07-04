// Задайте двумерный массив размером m×n, заполненный случайными целыми числами.
// m = 3, n = 4.
// 1 4 8 19
// 5 -2 33 -2
// 77 3 8 1

// здесь 2 метода, GetMatrix b тот где инициализируем массив. + к каждому метод на вывод массива, можно использовать отдельно get+вывод и init+вывод

System.Console.Write("Enter num rows: ");
int rows = Convert.ToInt32(Console.ReadLine());

System.Console.Write("Enter num columns: ");
int columns = Convert.ToInt32(Console.ReadLine());

int[,] matrix = InitMatrix(rows, columns);

Print(matrix);
Console.WriteLine(" ");

GetMatrix(matrix);
Print(matrix);

int[,] InitMatrix(int rows, int columns)
{
    int[,] tmp = new int[rows, columns];
    Random random = new Random();
    for (int i = 0; i < rows; i++)
    {
        for (int l = 0; l < columns; l ++)
        {
            tmp[i,l] = random.Next(10, 101);
        }
    }
    return tmp;
} 


void GetMatrix(int[,] arr)
{
    Random random = new Random();
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int l = 0; l < arr.GetLength(1); l ++)
        {
            arr[i,l] = random.Next(10, 101);
        }
    }
   
} 

void Print(int[,] arr)
{
for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int l = 0; l < arr.GetLength(1); l ++)
        {
          System.Console.Write($"{arr[i,l] } ");
        }
        System.Console.WriteLine();
    }
}    