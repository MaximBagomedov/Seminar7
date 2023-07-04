// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
Console.Write("Введите количество строк в массиве: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбец в массиве: ");
int n = Convert.ToInt32(Console.ReadLine());

double[,] array = new double[m , n];

Random random = new Random();
for (int i = 0; i < n; i++)
{
    for (int j = 0; j <= m; j++)
    {
        array[i, j] = Math.Round(random.NextDouble(), 2);
        Console.Write(array[i, j] + " ");
    }
    Console.WriteLine();
}


