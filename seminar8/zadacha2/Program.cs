// Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
Random random = new Random();
int[,] array = new int[4,5];
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {   
            array[i, j] = random.Next(1,25);
            Console.Write(array[i,j] + " ");
        }
        Console.WriteLine();
    }
}
Console.WriteLine();
int[] sumArr = new int[array.GetLength(0)];
Console.WriteLine($"Сумма по строке:");
for (int i = 0; i < array.GetLength(0); i++)
{
  for (int j = 0; j < array.GetLength(1); j++)
    {
      sumArr[i] += array[i, j];
    }
    Console.WriteLine($"{i + 1} -> {sumArr[i]}");
}
int minSum = sumArr[0];
int minRow = 1;
for (int i = 0; i < array.GetLength(0); i++)
{
    if (sumArr[i] < minSum)
    {
      minSum = sumArr[i];
      minRow = i + 1;
    }
    
}
Console.WriteLine($"Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: {minRow } строка");
