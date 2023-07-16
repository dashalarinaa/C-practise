// Написать рекурсивную функцию нахождения факториала

int GetFactorial(uint n)
{
    if (n == 0)
    {
        return 0;
    }
    int factorial = 1;
    for (int i = 1; i<=n; i++)
    {
        factorial = factorial * i;
    } 
    return factorial;
}

int GetRecFactorial(int n)
{
    if (n == 1) return 1;

    int temp = n * GetRecFactorial(n-1);
    return temp;
}

// ...........................................
Console.WriteLine("Введите число:");
int number = int.Parse(Console.ReadLine());

// int factorial = GetFactorial((uint) Math.Abs(number));

int factorial = GetRecFactorial(number);
Console.WriteLine($"Факториал вашего числа: {factorial}");

