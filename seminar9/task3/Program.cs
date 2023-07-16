// Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N

Console.Write("Введи целое число: ");
int number = int.Parse(Console.ReadLine());
Console.Write("Введи целое число: ");
int number_2 = int.Parse(Console.ReadLine());

int FillNatural(int M, int N)
{
    if (M -1  == N) return M;
    int temp = 1 + FillNatural(M, N-1);
    Console.WriteLine(N + "");
    return temp;
}

FillNatural(number, number_2);