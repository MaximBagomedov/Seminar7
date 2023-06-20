/*Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом. */

Console.WriteLine("Введите пятизначное число: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number > 9999 || number < 10000)
{
    Console.WriteLine("Вы вели не пятизначное число");
    Environment.Exit(0);
}
