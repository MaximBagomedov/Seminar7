//Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
for (int i = 1; i <= number; i++)
{
   double result = Math.Pow(i,3);

    Console.Write($"{result} ");
}
/*
double pow_a(int count)
{
    double result = Math.Pow(count, 3);
    return result;
}

Console.Write("Ведите число: ");
int n = Convert.ToInt32(Console.ReadLine());

int count = 1;

while (count <= n)
{
    double result = pow_a(count);
    Console.Write($"{result} ");
    count++;
}*/