/*Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2*/
Random random = new Random();
void Arrays (int[,] ar)
{
    for (int i = 0; i < ar.GetLength(0); i++)
    {
        for (int j = 0; j < ar.GetLength(1); j++)
        {
            ar[i, j] = random.Next(1,25);
            Console.Write(ar[i,j] + " ");
        }
        Console.WriteLine();
    }
}
int[,] array = new int[4,5];
void Arrays2 (int [,] arr2)
{
    
   for (int i = 0; i < arr2.GetLength(0); i++)
    {
        for (int j = 0; j < arr2.GetLength(1); j++)
        {
            for (int k = 0; k < arr2.GetLength(1) - 1; k++)
            {
                if (arr2[i, k] < arr2[i, k + 1])
                {
                    int temp = arr2[i, k + 1];
                    arr2[i, k + 1] = arr2[i, k];
                    arr2[i, k] = temp;
                    
                }
                
            }
        }
    }
}
void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}
Arrays(array);
Console.WriteLine();
Arrays2(array);
PrintArray (array);


