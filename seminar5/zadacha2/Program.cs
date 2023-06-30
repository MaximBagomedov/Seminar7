/* Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.*/

int [] array = new int [4];
Random random = new Random ();
int index = 0;
Console.Write("[");
for (int i = 0; i < array.Length; i++) 
{
    array[i] = random.Next (0, 100);
    Console.Write(array[i] + " ");
}
Console.Write("]-> ");
for (int i = 0; i < array.Length; i++) 
{
    if (array[i] % 2 != 0)
    {
        index = index + 1;
    }
}
Console.Write(index);