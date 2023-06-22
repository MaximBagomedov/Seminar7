// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
double ab(double x1, double x2, double x3, double y1, double y2, double y3) 
{ 
    double result = Math.Sqrt(Math.Pow(y1 - x1, 2) + Math.Pow(y2 - x2, 2) + Math.Pow(y3 - x3, 2));
    return result;
}

Console.Write("Ведите координату Х1: ");
double x1 = Convert.ToDouble(Console.ReadLine());

Console.Write("Ведите координату Х2: ");
double x2 = Convert.ToDouble(Console.ReadLine());

Console.Write("Ведите координату x3: ");
double x3 = Convert.ToDouble(Console.ReadLine());

Console.Write("Ведите координату Y1: ");
double y1 = Convert.ToDouble(Console.ReadLine());

Console.Write("Ведите координату Y2: ");
double y2 = Convert.ToDouble(Console.ReadLine());

Console.Write("Ведите координату Y3: ");
double y3 = Convert.ToDouble(Console.ReadLine());

double result = ab(x1, x2, x3, y1, y2, y3);
Console.WriteLine($"Расстояниен между координатами {Math.Round(result, 2, MidpointRounding.ToNegativeInfinity)}");