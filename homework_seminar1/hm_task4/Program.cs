// Напишите программу, которая на вход принимает 
// число (N), а на выходе показывает все чётные числа от 1 до N.
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

Console.Write("Введи целое число");
int number = int.Parse(Console.ReadLine());

int number_2 = 1; 

while (number_2 < number)
{
    number_2 % 2 == 0;
    number_2 = number_2 + 1;
}
