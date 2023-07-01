// Напишите программу, которая принимает на вход три числа и проверяет, может ли существовать треугольник с сторонами такой длины.
// Теорема о неравенстве треугольника: каждая сторона треугольника меньше суммы двух других сторон.
Console.Write("Введи целое число ");
int ab = int.Parse(Console.ReadLine());

Console.Write("Введи целое число ");
int bc = int.Parse(Console.ReadLine());

Console.Write("Введи целое число ");
int ac = int.Parse(Console.ReadLine());

if (ab < (bc+ac) && bc < (ab + ac) && ac < (bc + ab))
{
    Console.Write("Такой треугольник существует ");
}
else
{
    Console.Write("Такой треугольник не существует");
}
