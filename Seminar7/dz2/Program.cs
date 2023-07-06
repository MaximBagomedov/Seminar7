// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
Console.Write("Введите количество строк в массиве: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбец в массиве: ");
int n = Convert.ToInt32(Console.ReadLine());
int[,]array = new int[n,m];
Random random = new Random();
Array (array);
Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
Arrays (array, number);

void Array (int [,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for(int j = 0; j < arr.GetLength(1); j++)
        {
            array [i,j] = random.Next (0, 100);
            Console.Write(arr[i,j] + " ");
        } 
        Console.WriteLine();
    }
}
void Arrays (int [,] arr2, int numbers)
{
    int summ = 0;
    for (int i = 0; i < arr2.GetLength(0); i++)
    {
        
        for(int j = 0; j < arr2.GetLength(1); j++)
        {
           if(arr2 [i,j] == number)
           
           Console.WriteLine($"число {array[i, j]} находиться по адресу {i + 1} столбце {j+ 1} строки");
           summ = summ + 1;
        }     
    }
    if(summ == 0)
    {
        Console.WriteLine($"{number} -> такого числа в массиве нет"); 
    }
}