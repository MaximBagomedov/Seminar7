/*Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом. */

Console.WriteLine("Введите пятизначное число: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number > 99999 || number < 10000)
{
    Console.WriteLine("Вы вели не пятизначное число");
    Environment.Exit(0);
}
string str = number.ToString();
if(str[0] == str[4]||str[1] == str[3])
{
    Console.WriteLine("Поздравляю, введенное слово палиндром");
}
else
{
    Console.WriteLine("Введенное слово не является полиндромом");
}