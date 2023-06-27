// Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.
// 4; массив [6, 7, 19, 345, 3] -> нет
// 3; массив [6, 7, 19, 345, 3] -> да

Console.Write("Введите число: ");
int input_number = int.Parse(Console.ReadLine());

int[] array = {6, 7, 19, 345, 3};

for (int i = 0; i < array.Length; i++)
{
    if (input_number == array[i])
    {
        Console.WriteLine($"Число {input_number} присутстствует в массиве");
    }
    else
    {
        Console.WriteLine("Совпадений не выявлено");
    } 
}    

