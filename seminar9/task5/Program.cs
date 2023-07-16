// Напишите программу, которая на вход принимает два числа A и B, и возводит число A в целую степень B с помощью рекурсии

int GetRecStepen(int num_1, int num_2)
{
if (num_2 == 0) return 1;
int temp = GetRecStepen(num_1, num_2) * num_1;
return temp;  
}

Console.Write("Введите первое число: ");
int number_1 = int.Parse(Console.ReadLine());

Console.Write("Введите второе число: ");
int number_2 = int.Parse(Console.ReadLine());

Console.WriteLine(GetRecStepen(number_1, number_2));

// доделать

