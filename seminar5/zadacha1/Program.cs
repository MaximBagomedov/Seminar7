/* Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.*/

int [] array = new int [4];
Random random = new Random ();
int index = 0;
Console.Write("[");
for (int i = 0; i < array.Length; i++) 
{
    array[i] = random.Next (100, 1000);
    Console.Write(array[i] + " ");
    
}
Console.Write("]-> ");
for (int i = 0; i < array.Length; i++) 
{
    if (array[i] % 2 == 0 )
    {
        index = index + 1;
    }
  
}
System.Console.Write(index);