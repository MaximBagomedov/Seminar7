// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
Console.Write("Введите количество строк в массиве: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбец в массиве: ");
int n = Convert.ToInt32(Console.ReadLine());

double[,] array = new double[m , n];

Random random = new Random();
for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        array[i,j] =(double)random.Next(0,100)/ 10;
        Console.Write(array[i,j] + " ");
    }
    Console.WriteLine();
}


