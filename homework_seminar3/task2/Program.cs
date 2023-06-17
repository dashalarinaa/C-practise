// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

double GetDistance (int x1,int y1, int z1, int x2, int y2, int z2)
{
    double result = Math.Sqrt(Math.Pow((x2-x1), 2) + Math.Pow((y2-y1), 2) + Math.Pow((z2-z1), 2) );
    return result;
}

Console.Write("Введи координату x первого числа");
int x1 = int.Parse(Console.ReadLine());

Console.Write("Введи координату y первого числа");
int y1 = int.Parse(Console.ReadLine());

Console.Write("Введи координату z первого числа");
int z1 = int.Parse(Console.ReadLine());

Console.Write("Введи координату x второго числа");
int x2 = int.Parse(Console.ReadLine());

Console.Write("Введи координату y второго числа");
int y2 = int.Parse(Console.ReadLine());

Console.Write("Введи координату z второго числа");
int z2 = int.Parse(Console.ReadLine());

double finish = GetDistance(x1, y1, z1, x2, y2, z2);
Console.WriteLine($"Расстояние между точками: {finish}");