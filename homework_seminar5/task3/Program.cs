// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

double[] array = new double [5];
for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().NextDouble ();
    Console.WriteLine (array[i]);
}

double max = array[0];
double min = array[0];

for (int i = 0; i < array.Length; i++)
{
    if (array[i] > max)
    {
        max = array[i]; 
    }

     if (array[i] < min)
    {
        min = array[i];
    }
}
Console.WriteLine($" Максимальное значение = {max}, минимальное значение = {min}");
Console.WriteLine($"Разница между максимальным и минимальным значением = {max - min}");
