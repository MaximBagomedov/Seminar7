/* S Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.*/
int[,] arr = new int[4,4]; 
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for(int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i,j] = new Random().Next(0, 10);
            Console.Write(arr[i,j] + " ");
        } 
        Console.WriteLine();
    }
}
for (int i = 0; i < arr.GetLength(0); i++)
{   
    int sum = 0;
    double result = 0.0;
    for(int j = 0; j < arr.GetLength(1); j++)
    {
        sum = sum + arr [i,j];
    }
    result = (double) sum / arr.GetLength(1);
    Console.WriteLine($"Среднее арифметическое каждого столбца {i}: {result}" );

}