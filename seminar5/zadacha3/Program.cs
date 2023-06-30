/* Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
[3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76*/
double[] array = {3.22, 4.2, 1.15, 77.15, 65.2};
Random random = new Random();
Console.Write("[");
for (int i = 0; i <array.Length; i++ )
{
    Console.Write(array[i] + " ");
}
Console.Write("]-> ");
double max = 0;
double min = array[0];
for (int i = 0; i <array.Length; i++ )
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
double result = max - min;
System.Console.WriteLine($"{max} - {min} = {result}");