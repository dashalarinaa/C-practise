// Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от 1 до N.

Console.Write("Введи целое число: ");
int number = int.Parse(Console.ReadLine());

int FillNatural(int N)
{
    if (N == 0) return 1;
    int temp = 1 + FillNatural(N-1);
    Console.WriteLine(N + "");
    return temp;
}

FillNatural(number);