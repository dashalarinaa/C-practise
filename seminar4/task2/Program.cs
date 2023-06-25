/* Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.
4 -> 24 
5 -> 120 */

int GetFactorial(int number)
{
    int result = 1;
    for (int i = 1; i <= number; i++)
    {
         result = result * i;
    }
    return result;
}

Console.Write("Введи число: ");
int input_number = int.Parse(Console.ReadLine());

Console.WriteLine(GetFactorial(input_number));