//Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа 
//в промежутке от N до 1. Выполнить с помощью рекурсии.

string NumbersRec(int a, int n)
{
    if (a <= n) return NumbersRec(a + 1, n) + $"{a} ";
    else return String.Empty;
}
Console.WriteLine("Введите число");
int n = Convert.ToInt32(Console.ReadLine());
int a = 1;
Console.WriteLine(NumbersRec(a, n));