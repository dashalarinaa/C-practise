// Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

Console.Write("Введи целое число: ");
int number = int.Parse(Console.ReadLine());
Console.Write("Введи целое число: ");
int number_2 = int.Parse(Console.ReadLine());

int AkkermanFunction(int m, int n)
{

    if (m == 0)
    {
        return n + 1;
    }
    if (n == 0 && m > 0)
    {
        return AkkermanFunction(m - 1, 1);
    }
    else
    {
        return (AkkermanFunction(m - 1, AkkermanFunction(m, n - 1)));
    }
 
}

int Akkerman = AkkermanFunction(number, number_2);
Console.Write(Akkerman);