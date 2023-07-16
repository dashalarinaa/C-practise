// Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.Write("Введи целое число: ");
int number = int.Parse(Console.ReadLine());
Console.Write("Введи целое число: ");
int number_2 = int.Parse(Console.ReadLine());

int GetSum(int M, int N)
{
    if (M == N) return M;
    int temp = M + GetSum(M+1, N);
    return temp;
}

int sum = GetSum(number, number_2);
Console.WriteLine(sum);