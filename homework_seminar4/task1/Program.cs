// Напишите программу, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

int GetStepen(int num_1, int num_2)
{
int result = 1;
for (int i = 1; i <= num_2; i++)
{
    result = result * num_1;
}
return result;  
}

Console.Write("Введите первое число: ");
int number_1 = int.Parse(Console.ReadLine());

Console.Write("Введите второе число: ");
int number_2 = int.Parse(Console.ReadLine());

Console.WriteLine(GetStepen(number_1, number_2));
