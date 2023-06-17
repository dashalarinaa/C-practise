// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве.
// A (3,6); B (2,1) -> 5,09 
// A (7,-5); B (1,-1) -> 7,21

Console.Write("Введи координату x первого числа");
int x1 = int.Parse(Console.ReadLine());

Console.Write("Введи координату y первого числа");
int y1 = int.Parse(Console.ReadLine());

Console.Write("Введи координату x второго числа");
int x2 = int.Parse(Console.ReadLine());

Console.Write("Введи координату y второго числа");
int y2 = int.Parse(Console.ReadLine());


double a = Math.Pow((x1 - x2), 2);
double b = Math.Pow((y1 - y2), 2);

double result = Math.Sqrt(( a + b));

Console.WriteLine($"Расстояние между точками равно {result}");