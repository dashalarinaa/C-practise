// Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9]. Найдите сумму отрицательных и положительных элементов 
// массива.
// Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма положительных чисел равна 29, сумма отрицательных равна -20

int[] array = new int[12];
Console.Write("Исходный массив: ");
for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(-9, 10);
    Console.Write(array[i] + " ");
}

Console.WriteLine("");
int sum_pos = 0;
int sum_neg = 0;
for (int i = 0; i < array.Length; i++)
{
    if (array[i] > 0)
    {
        sum_pos = sum_pos + array[i];
    }

    if (array[i] < 0)
    {
        sum_neg = sum_neg + array[i];
    }
}

Console.WriteLine($"Сумма положительных чисел массива = {sum_pos}");
Console.WriteLine($"Сумма отрицательных чисел массива = {sum_neg}");