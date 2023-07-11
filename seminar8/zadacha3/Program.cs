// See https://aka.ms/new-console-template for more information

Console.Write("Введите количество строк в массиве: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбец в массиве: ");
int n = Convert.ToInt32(Console.ReadLine());

int[,] array = new int[m , n];

Random random = new Random();
for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        array[i,j] = random.Next(1,20);
        Console.Write(array[i,j] + " ");
    }
    Console.WriteLine();
}
Console.WriteLine();
int[,] array2 = new int[m , n];
for (int i = 0; i < array2.GetLength(0); i++)
{
    for (int j = 0; j < array2.GetLength(1); j++)
    {
        array2[i,j] =random.Next(1,20);
        Console.Write(array2[i,j] + " ");
    }
    Console.WriteLine();
}
Console.WriteLine();
int[,] newArray = new int[m, n];
{

  for (int i = 0; i < newArray.GetLength(0); i++)
  {
    for (int j = 0; j < newArray.GetLength(1); j++)
    {
      for (int e = 0; e < newArray.GetLength(0); e++)
      {
        newArray[i, j] += array[i, e] * array2[e, j];
        
      }
      Console.Write(newArray[i,j] + " ");
    } 
    Console.WriteLine(); 
  }   
}