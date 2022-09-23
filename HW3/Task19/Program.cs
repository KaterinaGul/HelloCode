// Напишите программу, которая принимает на вход пятизначное число
// и проверяет, является ли оно палиндромом.

Console.WriteLine("Введите пятизначное число: ");
int num = Convert.ToInt32(Console.ReadLine());

while (num > 99999 || num < 10000)
{
Console.WriteLine("Вы ввели не пятизначное число");
}
int a = num/10000;
int b = num/1000%10;
int c = num/10%10;
int d = num%10;

if
(a == d || b == c)
Console.Write("Введенное число является палиндромом");
else
{
    Console.WriteLine("Введенное число не является палиндромом");
}